const {app, BrowserWindow} = require('electron')

function createWindow() {
    // 创建浏览器窗口
    const win = new BrowserWindow({
        width: 800,
        height: 600,
        // frame:false,//让桌面应用没有边框，这样菜单栏也会消失
        webPreferences: {
            //这里进行加入
            enableRemoteModule: true,
            nodeIntegration: true,
            contextIsolation: false,
          }
    })

    //为electron应用加载index.html
    win.loadFile('index.html')

    //打开开发者工具
    win.webContents.openDevTools()

      // 发送给渲染线程
    setTimeout(() => {
    win.webContents.send('mainMsg', '我是主线程发送的消息')
        }, 3000)
}

// This method will be called when Electron has finished
// initialization and is ready to create browser windows.
// 部分 API 在 ready 事件触发后才能使用。
app.whenReady().then(createWindow)

// Quit when all windows are closed.
app.on('window-all-closed', () => {
    // 在 macOS 上，除非用户用 Cmd + Q 确定地退出，
    // 否则绝大部分应用及其菜单栏会保持激活。
    if (process.platform !== 'darwin') {
      app.quit()
    }
  })
  
  app.on('activate', () => {
    // 在macOS上，当单击dock图标并且没有其他窗口打开时，
    // 通常在应用程序中重新创建一个窗口。
    if (BrowserWindow.getAllWindows().length === 0) {
      createWindow()
    }
  })
  
  // In this file you can include the rest of your app's specific main process
  // code. 也可以拆分成几个文件，然后用 require 导入。

// 作者：小浪努力学前端
// 链接：https://juejin.cn/post/7015476516196712462
// 来源：稀土掘金
// 著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。