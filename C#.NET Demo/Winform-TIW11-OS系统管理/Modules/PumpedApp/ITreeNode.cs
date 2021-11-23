﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ThisIsWin11.PumpedApp.ITreeNode
{
    public static class ITreeNode
    {
        //retrieving TreeView nodes as IEnumerable
        public static IEnumerable<TreeNode> All(this TreeNodeCollection nodes)
        {
            if (nodes == null) throw new ArgumentNullException(nameof(nodes));

            foreach (TreeNode n in nodes)
            {
                yield return n;

                foreach (TreeNode child in n.Nodes.All())
                {
                    yield return child;
                }
            }
        }
    }
}