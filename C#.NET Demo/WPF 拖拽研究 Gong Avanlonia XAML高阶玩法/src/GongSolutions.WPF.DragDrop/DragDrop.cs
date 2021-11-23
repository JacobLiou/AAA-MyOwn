using System;
using System.Collections;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using GongSolutions.Wpf.DragDrop.Icons;
using GongSolutions.Wpf.DragDrop.Utilities;

namespace GongSolutions.Wpf.DragDrop
{
    public static partial class DragDrop
    {
        private static DragDropPreview GetDragDropPreview(DropInfo dropInfo, UIElement target)
        {
            var dragInfo = dropInfo.DragInfo;
            var template = GetDropAdornerTemplate(dropInfo.VisualTarget) ?? GetDragAdornerTemplate(dragInfo.VisualSource);
            var templateSelector = GetDropAdornerTemplateSelector(dropInfo.VisualTarget) ?? GetDragAdornerTemplateSelector(dragInfo.VisualSource);

            UIElement adornment = null;

            var useDefaultDragAdorner = template == null && templateSelector == null && GetUseDefaultDragAdorner(dragInfo.VisualSource);
            var useVisualSourceItemSizeForDragAdorner = GetUseVisualSourceItemSizeForDragAdorner(dragInfo.VisualSource);

            if (useDefaultDragAdorner)
            {
                template = dragInfo.VisualSourceItem.GetCaptureScreenDataTemplate(dragInfo.VisualSourceFlowDirection);
            }

            if (template != null || templateSelector != null)
            {
                if (dragInfo.Data is IEnumerable items && !(items is string))
                {
                    var itemsCount = items.Cast<object>().Count();
                    var maxItemsCount = TryGetDragPreviewMaxItemsCount(dragInfo, target);
                    if (!useDefaultDragAdorner && itemsCount <= maxItemsCount)
                    {
                        var itemsControl = new ItemsControl();

                        // sort items if necessary before creating the preview
                        var sorter = TryGetDragPreviewItemsSorter(dragInfo, target);
                        if (sorter != null)
                        {
                            itemsControl.ItemsSource = sorter.SortDragPreviewItems(items);
                        }
                        else
                        {
                            itemsControl.ItemsSource = items;
                        }

                        itemsControl.ItemTemplate = template;
                        itemsControl.ItemTemplateSelector = templateSelector;
                        itemsControl.Tag = dragInfo;

                        if (useVisualSourceItemSizeForDragAdorner)
                        {
                            var bounds = VisualTreeExtensions.GetVisibleDescendantBounds(dragInfo.VisualSourceItem);
                            itemsControl.SetValue(FrameworkElement.MinWidthProperty, bounds.Width);
                        }

                        // The ItemsControl doesn't display unless we create a grid to contain it.
                        // Not quite sure why we need this...
                        var grid = new Grid();
                        grid.Children.Add(itemsControl);
                        adornment = grid;
                    }
                }
                else
                {
                    var contentPresenter = new ContentPresenter();
                    contentPresenter.Content = dragInfo.Data;
                    contentPresenter.ContentTemplate = template;
                    contentPresenter.ContentTemplateSelector = templateSelector;
                    contentPresenter.Tag = dragInfo;

                    if (useVisualSourceItemSizeForDragAdorner)
                    {
                        var bounds = VisualTreeExtensions.GetVisibleDescendantBounds(dragInfo.VisualSourceItem);
                        contentPresenter.SetValue(FrameworkElement.MinWidthProperty, bounds.Width);
                        contentPresenter.SetValue(FrameworkElement.MinHeightProperty, bounds.Height);
                    }

                    adornment = contentPresenter;
                }
            }

            if (adornment != null)
            {
                if (useDefaultDragAdorner)
                {
                    adornment.Opacity = GetDefaultDragAdornerOpacity(dragInfo.VisualSource);
                }

                var rootElement = TryGetRootElementFinder(target).FindRoot(dropInfo.VisualTarget ?? dragInfo.VisualSource);

                var preview = new DragDropPreview(rootElement, adornment, GetDragAdornerTranslation(dragInfo.VisualSource), GetDragMouseAnchorPoint(dragInfo.VisualSource)) { IsOpen = true };
                return preview;
            }

            return null;
        }

        private static DragDropEffectPreview GetDragDropEffectPreview(DropInfo dropInfo, UIElement sender)
        {
            var dragInfo = dropInfo.DragInfo;
            var template = GetDragDropEffecTemplate(dragInfo.VisualSource, dropInfo);

            if (template != null)
            {
                var rootElement = TryGetRootElementFinder(sender).FindRoot(dropInfo.VisualTarget ?? dragInfo.VisualSource);

                var adornment = new ContentPresenter { Content = dragInfo.Data, ContentTemplate = template };

                var preview = new DragDropEffectPreview(rootElement, adornment, GetEffectAdornerTranslation(dragInfo.VisualSource), dropInfo.Effects, dropInfo.EffectText, dropInfo.DestinationText) { IsOpen = true };
                return preview;
            }

            return null;
        }

        private static DataTemplate GetDragDropEffecTemplate(UIElement target, DropInfo dropInfo)
        {
            if (target is null)
            {
                return null;
            }

            var effectText = dropInfo.EffectText;
            var destinationText = dropInfo.DestinationText;

            return dropInfo.Effects switch
            {
                DragDropEffects.All => GetEffectAllAdornerTemplate(target), // TODO: Add default template for EffectAll
                DragDropEffects.Copy => GetEffectCopyAdornerTemplate(target) ?? CreateDefaultEffectDataTemplate(target, IconFactory.EffectCopy, string.IsNullOrEmpty(effectText) ? "Copy to" : effectText, destinationText),
                DragDropEffects.Link => GetEffectLinkAdornerTemplate(target) ?? CreateDefaultEffectDataTemplate(target, IconFactory.EffectLink, string.IsNullOrEmpty(effectText) ? "Link to" : effectText, destinationText),
                DragDropEffects.Move => GetEffectMoveAdornerTemplate(target) ?? CreateDefaultEffectDataTemplate(target, IconFactory.EffectMove, string.IsNullOrEmpty(effectText) ? "Move to" : effectText, destinationText),
                DragDropEffects.None => GetEffectNoneAdornerTemplate(target) ?? CreateDefaultEffectDataTemplate(target, IconFactory.EffectNone, string.IsNullOrEmpty(effectText) ? "None" : effectText, destinationText),
                DragDropEffects.Scroll => GetEffectScrollAdornerTemplate(target), // TODO: Add default template EffectScroll
                _ => null
            };
        }

        private static DataTemplate CreateDefaultEffectDataTemplate(UIElement target, BitmapImage effectIcon, string effectText, string destinationText)
        {
            if (!GetUseDefaultEffectDataTemplate(target))
            {
                return null;
            }

            var fontSize = SystemFonts.MessageFontSize; // before 11d

            // The icon
            var imageFactory = new FrameworkElementFactory(typeof(Image));
            imageFactory.SetValue(Image.SourceProperty, effectIcon);
            imageFactory.SetValue(FrameworkElement.HeightProperty, 12d);
            imageFactory.SetValue(FrameworkElement.WidthProperty, 12d);

            // Only the icon for no effect
            if (Equals(effectIcon, GongSolutions.Wpf.DragDrop.Icons.IconFactory.EffectNone))
            {
                return new DataTemplate { VisualTree = imageFactory };
            }

            // Some margin for the icon
            imageFactory.SetValue(FrameworkElement.MarginProperty, new Thickness(0, 0, 3, 0));
            imageFactory.SetValue(FrameworkElement.VerticalAlignmentProperty, VerticalAlignment.Center);

            // Add effect text
            var effectTextBlockFactory = new FrameworkElementFactory(typeof(TextBlock));
            effectTextBlockFactory.SetValue(TextBlock.TextProperty, effectText);
            effectTextBlockFactory.SetValue(TextBlock.FontSizeProperty, fontSize);
            effectTextBlockFactory.SetValue(TextBlock.ForegroundProperty, Brushes.Blue);
            effectTextBlockFactory.SetValue(FrameworkElement.VerticalAlignmentProperty, VerticalAlignment.Center);

            // Add destination text
            var destinationTextBlockFactory = new FrameworkElementFactory(typeof(TextBlock));
            destinationTextBlockFactory.SetValue(TextBlock.TextProperty, destinationText);
            destinationTextBlockFactory.SetValue(TextBlock.FontSizeProperty, fontSize);
            destinationTextBlockFactory.SetValue(TextBlock.ForegroundProperty, Brushes.DarkBlue);
            destinationTextBlockFactory.SetValue(TextBlock.MarginProperty, new Thickness(3, 0, 0, 0));
            destinationTextBlockFactory.SetValue(TextBlock.FontWeightProperty, FontWeights.DemiBold);
            destinationTextBlockFactory.SetValue(FrameworkElement.VerticalAlignmentProperty, VerticalAlignment.Center);

            // Create containing panel
            var stackPanelFactory = new FrameworkElementFactory(typeof(StackPanel));
            stackPanelFactory.SetValue(StackPanel.OrientationProperty, Orientation.Horizontal);
            stackPanelFactory.SetValue(FrameworkElement.MarginProperty, new Thickness(2));
            stackPanelFactory.SetValue(FrameworkElement.VerticalAlignmentProperty, VerticalAlignment.Center);
            stackPanelFactory.AppendChild(imageFactory);
            stackPanelFactory.AppendChild(effectTextBlockFactory);
            stackPanelFactory.AppendChild(destinationTextBlockFactory);

            // Add border
            var borderFactory = new FrameworkElementFactory(typeof(Border));
            var stopCollection = new GradientStopCollection
                                 {
                                     new GradientStop(Colors.White, 0.0),
                                     new GradientStop(Colors.AliceBlue, 1.0)
                                 };
            var gradientBrush = new LinearGradientBrush(stopCollection)
                                {
                                    StartPoint = new Point(0, 0),
                                    EndPoint = new Point(0, 1)
                                };
            borderFactory.SetValue(Panel.BackgroundProperty, gradientBrush);
            borderFactory.SetValue(Border.BorderBrushProperty, Brushes.DimGray);
            borderFactory.SetValue(Border.CornerRadiusProperty, new CornerRadius(3));
            borderFactory.SetValue(Border.BorderThicknessProperty, new Thickness(1));
            borderFactory.SetValue(Border.SnapsToDevicePixelsProperty, true);
            borderFactory.SetValue(TextOptions.TextFormattingModeProperty, TextFormattingMode.Display);
            borderFactory.SetValue(TextOptions.TextRenderingModeProperty, TextRenderingMode.ClearType);
            borderFactory.SetValue(TextOptions.TextHintingModeProperty, TextHintingMode.Fixed);
            borderFactory.AppendChild(stackPanelFactory);

            // Finally add content to template
            return new DataTemplate { VisualTree = borderFactory };
        }

        private static void Scroll(DropInfo dropInfo, DragEventArgs e)
        {
            if (dropInfo?.TargetScrollViewer is null)
            {
                return;
            }

            var scrollViewer = dropInfo.TargetScrollViewer;
            var scrollingMode = dropInfo.TargetScrollingMode;

            var position = e.GetPosition(scrollViewer);
            var scrollMargin = Math.Min(scrollViewer.FontSize * 2, scrollViewer.ActualHeight / 2);

            if (scrollingMode == ScrollingMode.Both || scrollingMode == ScrollingMode.HorizontalOnly)
            {
                if (position.X >= scrollViewer.ActualWidth - scrollMargin && scrollViewer.HorizontalOffset < scrollViewer.ExtentWidth - scrollViewer.ViewportWidth)
                {
                    scrollViewer.LineRight();
                }
                else if (position.X < scrollMargin && scrollViewer.HorizontalOffset > 0)
                {
                    scrollViewer.LineLeft();
                }
            }

            if (scrollingMode == ScrollingMode.Both || scrollingMode == ScrollingMode.VerticalOnly)
            {
                if (position.Y >= scrollViewer.ActualHeight - scrollMargin && scrollViewer.VerticalOffset < scrollViewer.ExtentHeight - scrollViewer.ViewportHeight)
                {
                    scrollViewer.LineDown();
                }
                else if (position.Y < scrollMargin && scrollViewer.VerticalOffset > 0)
                {
                    scrollViewer.LineUp();
                }
            }
        }

        /// <summary>
        /// Gets the drag handler from the drag info or from the sender, if the drag info is null
        /// </summary>
        /// <param name="dragInfo">the drag info object</param>
        /// <param name="sender">the sender from an event, e.g. mouse down, mouse move</param>
        /// <returns></returns>
        private static IDragSource TryGetDragHandler(IDragInfo dragInfo, UIElement sender)
        {
            var dragHandler = dragInfo?.VisualSource != null ? GetDragHandler(dragInfo.VisualSource) : null;
            if (dragHandler is null && sender != null)
            {
                dragHandler = GetDragHandler(sender);
            }

            return dragHandler ?? DefaultDragHandler;
        }

        /// <summary>
        /// Gets the drop handler from the drop info or from the sender, if the drop info is null
        /// </summary>
        /// <param name="dropInfo">the drop info object</param>
        /// <param name="sender">the sender from an event, e.g. drag over</param>
        /// <returns></returns>
        private static IDropTarget TryGetDropHandler(DropInfo dropInfo, UIElement sender)
        {
            var dropHandler = dropInfo?.VisualTarget != null ? GetDropHandler(dropInfo.VisualTarget) : null;
            if (dropHandler is null && sender != null)
            {
                dropHandler = GetDropHandler(sender);
            }

            return dropHandler ?? DefaultDropHandler;
        }

        /// <summary>
        /// Gets the RootElementFinder from the sender or uses the default implementation, if it's null.
        /// </summary>
        /// <param name="sender">the sender from an event, e.g. drag over</param>
        /// <returns></returns>
        private static IRootElementFinder TryGetRootElementFinder(UIElement sender)
        {
            var rootElementFinder = sender != null ? GetRootElementFinder(sender) : null;

            return rootElementFinder ?? DefaultRootElementFinder;
        }

        private static int TryGetDragPreviewMaxItemsCount(IDragInfo dragInfo, UIElement sender)
        {
            var itemsCount = dragInfo?.VisualSource != null ? GetDragPreviewMaxItemsCount(dragInfo.VisualSource) : -1;
            if (itemsCount < 0 && sender != null)
            {
                itemsCount = GetDragPreviewMaxItemsCount(sender);
            }

            return itemsCount < 0 || itemsCount >= int.MaxValue ? 10 : itemsCount;
        }

        private static IDragPreviewItemsSorter TryGetDragPreviewItemsSorter(IDragInfo dragInfo, UIElement sender)
        {
            var itemsSorter = dragInfo?.VisualSource != null ? GetDragPreviewItemsSorter(dragInfo.VisualSource) : null;
            if (itemsSorter is null && sender != null)
            {
                itemsSorter = GetDragPreviewItemsSorter(sender);
            }

            return itemsSorter;
        }

        private static IDropTargetItemsSorter TryGetDropTargetItemsSorter(IDropInfo dropInfo, UIElement sender)
        {
            var itemsSorter = dropInfo?.VisualTarget != null ? GetDropTargetItemsSorter(dropInfo.VisualTarget) : null;
            if (itemsSorter is null && sender != null)
            {
                itemsSorter = GetDropTargetItemsSorter(sender);
            }

            return itemsSorter;
        }

        private static void DragSourceOnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DoMouseButtonDown(sender, e);
        }

        private static void DragSourceOnMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            DoMouseButtonDown(sender, e);
        }

        private static void DragSourceOnTouchDown(object sender, TouchEventArgs e)
        {
            _dragInfo = null;

            // Ignore the click if clickCount != 1 or the user has clicked on a scrollbar.
            var elementPosition = e.GetTouchPoint((IInputElement)sender).Position;
            if ((sender as UIElement).IsDragSourceIgnored()
                || (e.Source as UIElement).IsDragSourceIgnored()
                || (e.OriginalSource as UIElement).IsDragSourceIgnored()
                || GetHitTestResult(sender, elementPosition)
                || HitTestUtilities.IsNotPartOfSender(sender, e))
            {
                return;
            }

            var dragInfo = new DragInfo(sender, e);

            DragSourceDown(sender, dragInfo, e);
        }

        private static void DoMouseButtonDown(object sender, MouseButtonEventArgs e)
        {
            _dragInfo = null;

            // Ignore the click if clickCount != 1 or the user has clicked on a scrollbar.
            var elementPosition = e.GetPosition((IInputElement)sender);
            if (e.ClickCount != 1
                || (sender as UIElement).IsDragSourceIgnored()
                || (e.Source as UIElement).IsDragSourceIgnored()
                || (e.OriginalSource as UIElement).IsDragSourceIgnored()
                || GetHitTestResult(sender, elementPosition)
                || HitTestUtilities.IsNotPartOfSender(sender, e))
            {
                return;
            }

            var dragInfo = new DragInfo(sender, e);

            DragSourceDown(sender, dragInfo, e);
        }

        private static void DragSourceDown(object sender, DragInfo dragInfo, InputEventArgs e)
        {
            if (dragInfo.VisualSource is ItemsControl control && control.CanSelectMultipleItems())
            {
                control.Focus();
            }

            if (dragInfo.VisualSourceItem == null)
            {
                return;
            }

            var dragHandler = TryGetDragHandler(dragInfo, sender as UIElement);
            if (!dragHandler.CanStartDrag(dragInfo))
            {
                return;
            }

            // If the sender is a list box that allows multiple selections, ensure that clicking on an 
            // already selected item does not change the selection, otherwise dragging multiple items 
            // is made impossible.
            var itemsControl = sender as ItemsControl;
            if ((Keyboard.Modifiers & ModifierKeys.Shift) == 0 && (Keyboard.Modifiers & ModifierKeys.Control) == 0 && dragInfo.VisualSourceItem != null && itemsControl != null && itemsControl.CanSelectMultipleItems())
            {
                var selectedItems = itemsControl.GetSelectedItems().OfType<object>().ToList();
                if (selectedItems.Count > 1 && selectedItems.Contains(dragInfo.SourceItem))
                {
                    _clickSupressItem = dragInfo.SourceItem;
                    e.Handled = true;
                }
            }

            _dragInfo = dragInfo;
        }

        private static void DragSourceOnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            DoMouseButtonUp(sender, e);
        }

        private static void DragSourceOnMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            DoMouseButtonUp(sender, e);
        }

        private static void DragSourceOnTouchUp(object sender, TouchEventArgs e)
        {
            DragSourceUp(sender, e.GetTouchPoint((IInputElement)sender).Position);
        }

        private static void DoMouseButtonUp(object sender, MouseButtonEventArgs e)
        {
            DragSourceUp(sender, e.GetPosition((IInputElement)sender));
        }

        private static void DragSourceUp(object sender, Point elementPosition)
        {
            var dragInfo = _dragInfo;

            // If we prevented the control's default selection handling in DragSource_PreviewMouseLeftButtonDown
            // by setting 'e.Handled = true' and a drag was not initiated, manually set the selection here.
            if (dragInfo?.VisualSource is ItemsControl itemsControl && _clickSupressItem != null && _clickSupressItem == dragInfo.SourceItem)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) != 0 || itemsControl is ListBox listBox && listBox.SelectionMode == SelectionMode.Multiple)
                {
                    itemsControl.SetItemSelected(dragInfo.SourceItem, false);
                }
                else if ((Keyboard.Modifiers & ModifierKeys.Shift) == 0)
                {
                    itemsControl.SetSelectedItem(dragInfo.SourceItem);

                    if (sender != itemsControl && sender is ItemsControl ancestorItemsControl)
                    {
                        var ancestorItemContainer = ancestorItemsControl.ContainerFromElement(itemsControl);

                        if (ancestorItemContainer != null)
                        {
                            var ancestorItem = ancestorItemsControl.ItemContainerGenerator.ItemFromContainer(ancestorItemContainer);

                            if (ancestorItem != null)
                            {
                                ancestorItemsControl.SetSelectedItem(ancestorItem);
                            }
                        }
                    }
                }
            }

            _dragInfo = null;
            _clickSupressItem = null;
        }

        private static void DragSourceOnTouchMove(object sender, TouchEventArgs e)
        {
            if (_dragInfo != null && !_dragInProgress)
            {
                // do nothing if mouse left/right button is released or the pointer is captured
                if (_dragInfo.MouseButton == MouseButton.Left && !e.TouchDevice.IsActive)
                {
                    _dragInfo = null;
                    return;
                }

                DoDragSourceMove(sender, e.GetTouchPoint((IInputElement)sender).Position);
            }
        }

        private static void DragSourceOnMouseMove(object sender, MouseEventArgs e)
        {
            if (_dragInfo != null && !_dragInProgress)
            {
                if (_dragInfo.MouseButton == MouseButton.Left && e.LeftButton == MouseButtonState.Released)
                {
                    _dragInfo = null;
                    return;
                }

                if (GetCanDragWithMouseRightButton(_dragInfo.VisualSource)
                    && _dragInfo.MouseButton == MouseButton.Right
                    && e.RightButton == MouseButtonState.Released)
                {
                    _dragInfo = null;
                    return;
                }

                DoDragSourceMove(sender, e.GetPosition((IInputElement)sender));
            }
        }

        private static void DoDragSourceMove(object sender, Point position)
        {
            var dragInfo = _dragInfo;
            if (dragInfo != null && !_dragInProgress)
            {
                // the start from the source
                var dragStart = dragInfo.DragStartPosition;

                // prevent selection changing while drag operation
                dragInfo.VisualSource?.ReleaseMouseCapture();

                // only if the sender is the source control and the mouse point differs from an offset
                if (dragInfo.VisualSource == sender
                    && (Math.Abs(position.X - dragStart.X) > DragDrop.GetMinimumHorizontalDragDistance(dragInfo.VisualSource) ||
                        Math.Abs(position.Y - dragStart.Y) > DragDrop.GetMinimumVerticalDragDistance(dragInfo.VisualSource)))
                {
                    dragInfo.RefreshSelectedItems(sender);

                    var dragHandler = TryGetDragHandler(dragInfo, sender as UIElement);
                    if (dragHandler.CanStartDrag(dragInfo))
                    {
                        dragHandler.StartDrag(dragInfo);

                        if (dragInfo.Effects != DragDropEffects.None)
                        {
                            var dataObject = dragInfo.DataObject;

                            if (dataObject == null)
                            {
                                if (dragInfo.Data == null)
                                {
                                    // it's bad if the Data is null, cause the DataObject constructor will raise an ArgumentNullException
                                    _dragInfo = null; // maybe not necessary or should not set here to null
                                    return;
                                }

                                dataObject = new DataObject(dragInfo.DataFormat.Name, dragInfo.Data);
                            }

                            var hookId = IntPtr.Zero;

                            try
                            {
                                _dragInProgress = true;
                                hookId = NativeMethods.HookMouseMove(point =>
                                    {
                                        DragDropPreview?.Move(DragDropPreview.PlacementTarget.PointFromScreen(point));
                                        DragDropEffectPreview?.Move(DragDropEffectPreview.PlacementTarget.PointFromScreen(point));
                                    });

                                var dragDropHandler = dragInfo.DragDropHandler ?? System.Windows.DragDrop.DoDragDrop;
                                var dragDropEffects = dragDropHandler(dragInfo.VisualSource, dataObject, dragInfo.Effects);
                                if (dragDropEffects == DragDropEffects.None)
                                {
                                    dragHandler.DragCancelled();
                                }

                                dragHandler.DragDropOperationFinished(dragDropEffects, dragInfo);
                            }
                            catch (Exception ex)
                            {
                                if (!dragHandler.TryCatchOccurredException(ex))
                                {
                                    throw;
                                }
                            }
                            finally
                            {
                                NativeMethods.RemoveHook(hookId);
                                _dragInProgress = false;
                                _dragInfo = null;
                            }
                        }
                    }
                }
            }
        }

        private static void DragSourceOnQueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            if (e.Action == DragAction.Cancel || e.EscapePressed || (e.KeyStates.HasFlag(DragDropKeyStates.LeftMouseButton) == false && e.KeyStates.HasFlag(DragDropKeyStates.RightMouseButton) == false))
            {
                DragDropPreview = null;
                DragDropEffectPreview = null;
                DropTargetAdorner = null;
                Mouse.OverrideCursor = null;
            }
        }

        private static void DropTargetOnDragEnter(object sender, DragEventArgs e)
        {
            DropTargetOnDragOver(sender, e, EventType.Bubbled);
        }

        private static void DropTargetOnPreviewDragEnter(object sender, DragEventArgs e)
        {
            DropTargetOnDragOver(sender, e, EventType.Tunneled);
        }

        private static void DropTargetOnDragLeave(object sender, DragEventArgs e)
        {
            _isDragOver = false;
            DropTargetAdorner = null;

            (sender as UIElement)?.Dispatcher.BeginInvoke(new Action(() =>
                {
                    if (_isDragOver == false)
                    {
                        OnRealTargetDragLeave(sender, e);
                    }
                }));
        }

        private static void OnRealTargetDragLeave(object sender, DragEventArgs dragEventArgs)
        {
            DragDropEffectPreview = null;
            DropTargetAdorner = null;
        }

        private static void DropTargetOnDragOver(object sender, DragEventArgs e)
        {
            DropTargetOnDragOver(sender, e, EventType.Bubbled);
        }

        private static void DropTargetOnPreviewDragOver(object sender, DragEventArgs e)
        {
            DropTargetOnDragOver(sender, e, EventType.Tunneled);
        }

        private static void DropTargetOnDragOver(object sender, DragEventArgs e, EventType eventType)
        {
            _isDragOver = true;

            var elementPosition = e.GetPosition((IInputElement)sender);

            var dragInfo = _dragInfo;
            var dropInfo = new DropInfo(sender, e, dragInfo, eventType);
            var dropHandler = TryGetDropHandler(dropInfo, sender as UIElement);
            var itemsControl = dropInfo.VisualTarget;

            dropHandler.DragOver(dropInfo);

            if (DragDropPreview is null && dragInfo is { })
            {
                DragDropPreview = GetDragDropPreview(dropInfo, sender as UIElement);
                DragDropPreview?.Move(e.GetPosition(DragDropPreview.PlacementTarget));
            }

            Scroll(dropInfo, e);

            if (HitTestUtilities.HitTest4Type<ScrollBar>(sender, elementPosition)
                || HitTestUtilities.HitTest4GridViewColumnHeader(sender, elementPosition)
                || HitTestUtilities.HitTest4DataGridTypesOnDragOver(sender, elementPosition))
            {
                e.Effects = DragDropEffects.None;
                e.Handled = true;
                return;
            }

            // If the target is an ItemsControl then update the drop target adorner.
            if (itemsControl != null)
            {
                // Display the adorner in the control's ItemsPresenter. If there is no 
                // ItemsPresenter provided by the style, try getting hold of a
                // ScrollContentPresenter and using that.
                UIElement adornedElement = null;
                if (itemsControl is TabControl)
                {
                    adornedElement = itemsControl.GetVisualDescendent<TabPanel>();
                }
                else if (itemsControl is DataGrid || (itemsControl as ListView)?.View is GridView)
                {
                    adornedElement = itemsControl.GetVisualDescendent<ScrollContentPresenter>() as UIElement ?? itemsControl.GetVisualDescendent<ItemsPresenter>() as UIElement ?? itemsControl;
                }
                else
                {
                    adornedElement = itemsControl.GetVisualDescendent<ItemsPresenter>() as UIElement ?? itemsControl.GetVisualDescendent<ScrollContentPresenter>() as UIElement ?? itemsControl;
                }

                if (adornedElement != null)
                {
                    if (dropInfo.DropTargetAdorner == null)
                    {
                        DropTargetAdorner = null;
                    }
                    else if (!dropInfo.DropTargetAdorner.IsInstanceOfType(DropTargetAdorner))
                    {
                        DropTargetAdorner = DropTargetAdorner.Create(dropInfo.DropTargetAdorner, adornedElement, dropInfo);
                    }

                    var adorner = DropTargetAdorner;
                    if (adorner != null)
                    {
                        var adornerBrush = GetDropTargetAdornerBrush(dropInfo.VisualTarget);
                        if (adornerBrush != null)
                        {
                            adorner.Pen.Brush = adornerBrush;
                        }

                        adorner.DropInfo = dropInfo;
                        adorner.InvalidateVisual();
                    }
                }
            }

            // Set the drag effect adorner if there is one
            if (dragInfo != null)
            {
                if (DragDropEffectPreview is null)
                {
                    DragDropEffectPreview = GetDragDropEffectPreview(dropInfo, sender as UIElement);
                    DragDropEffectPreview?.Move(e.GetPosition(DragDropEffectPreview.PlacementTarget));
                }
                else if (DragDropEffectPreview.Effects != dropInfo.Effects || DragDropEffectPreview.EffectText != dropInfo.EffectText || DragDropEffectPreview.DestinationText != dropInfo.DestinationText)
                {
                    DragDropEffectPreview.Effects = dropInfo.Effects;
                    DragDropEffectPreview.EffectText = dropInfo.EffectText;
                    DragDropEffectPreview.DestinationText = dropInfo.DestinationText;

                    var template = GetDragDropEffecTemplate(dragInfo.VisualSource, dropInfo);
                    if (template is null)
                    {
                        DragDropEffectPreview = null;
                    }
                    else
                    {
                        ((ContentPresenter)DragDropEffectPreview.Child).SetCurrentValue(ContentPresenter.ContentTemplateProperty, template);
                    }
                }
            }

            e.Effects = dropInfo.Effects;
            e.Handled = !dropInfo.NotHandled;

            if (!dropInfo.IsSameDragDropContextAsSource)
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private static void DropTargetOnDrop(object sender, DragEventArgs e)
        {
            DropTargetOnDrop(sender, e, EventType.Bubbled);
        }

        private static void DropTargetOnPreviewDrop(object sender, DragEventArgs e)
        {
            DropTargetOnDrop(sender, e, EventType.Tunneled);
        }

        private static void DropTargetOnDrop(object sender, DragEventArgs e, EventType eventType)
        {
            var dragInfo = _dragInfo;
            var dropInfo = new DropInfo(sender, e, dragInfo, eventType);
            var dropHandler = TryGetDropHandler(dropInfo, sender as UIElement);
            var dragHandler = TryGetDragHandler(dragInfo, sender as UIElement);
            var itemsSorter = TryGetDropTargetItemsSorter(dropInfo, sender as UIElement);

            DragDropPreview = null;
            DragDropEffectPreview = null;
            DropTargetAdorner = null;

            dropHandler.DragOver(dropInfo);
            if (itemsSorter != null && dropInfo.Data is IEnumerable enumerable && !(enumerable is string))
            {
                dropInfo.Data = itemsSorter.SortDropTargetItems(enumerable);
            }

            dropHandler.Drop(dropInfo);
            dragHandler.Dropped(dropInfo);

            e.Effects = dropInfo.Effects;
            e.Handled = !dropInfo.NotHandled;

            Mouse.OverrideCursor = null;
        }

        private static void DropTargetOnGiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            if (DragDropEffectPreview != null)
            {
                e.UseDefaultCursors = false;
                e.Handled = true;
                if (Mouse.OverrideCursor != Cursors.Arrow)
                {
                    Mouse.OverrideCursor = Cursors.Arrow;
                }
            }
            else
            {
                e.UseDefaultCursors = true;
                e.Handled = true;
                if (Mouse.OverrideCursor != null)
                {
                    Mouse.OverrideCursor = null;
                }
            }
        }

        private static bool GetHitTestResult(object sender, Point elementPosition)
        {
            return ((sender is TabControl) && !HitTestUtilities.HitTest4Type<TabPanel>(sender, elementPosition))
                   || HitTestUtilities.HitTest4Type<RangeBase>(sender, elementPosition)
                   || HitTestUtilities.HitTest4Type<TextBoxBase>(sender, elementPosition)
                   || HitTestUtilities.HitTest4Type<PasswordBox>(sender, elementPosition)
                   || HitTestUtilities.HitTest4Type<ComboBox>(sender, elementPosition)
                   || HitTestUtilities.HitTest4Type<ToggleButton>(sender, elementPosition)
                   || HitTestUtilities.HitTest4Type<MenuBase>(sender, elementPosition)
                   || HitTestUtilities.HitTest4GridViewColumnHeader(sender, elementPosition)
                   || HitTestUtilities.HitTest4DataGridTypes(sender, elementPosition);
        }

        private static DragDropPreview dragDropPreview;

        private static DragDropPreview DragDropPreview
        {
            get => dragDropPreview;
            set
            {
                dragDropPreview?.SetCurrentValue(Popup.IsOpenProperty, false);
                dragDropPreview = value;
            }
        }

        private static DragDropEffectPreview dragDropEffectPreview;

        private static DragDropEffectPreview DragDropEffectPreview
        {
            get => dragDropEffectPreview;
            set
            {
                if (dragDropEffectPreview is { })
                {
                    dragDropEffectPreview.SetCurrentValue(Popup.PopupAnimationProperty, PopupAnimation.None);
                    dragDropEffectPreview.SetCurrentValue(Popup.IsOpenProperty, false);
                }

                dragDropEffectPreview = value;
            }
        }

        private static DropTargetAdorner dropTargetAdorner;

        private static DropTargetAdorner DropTargetAdorner
        {
            get => dropTargetAdorner;
            set
            {
                dropTargetAdorner?.Detatch();
                dropTargetAdorner = value;
            }
        }

        private static bool _isDragOver;
        private static DragInfo _dragInfo;
        private static bool _dragInProgress;
        private static object _clickSupressItem;
    }
}