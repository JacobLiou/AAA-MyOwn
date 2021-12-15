using Microsoft.Playwright;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

using var playwright = await Playwright.CreateAsync();
// playwright.Chromium.ExecutablePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
//await using C# 8语法 针对实现了IAsyncDisposable接口 异步去清理资源 提高并发
await using var browser = await playwright.Chromium.LaunchAsync();
// var browser = await playwright.Chromium.LaunchAsync();
var page = await browser.NewPageAsync();
await page.GotoAsync("https://github.com");
await page.ScreenshotAsync(new PageScreenshotOptions{ Path = "screenshot.png"});