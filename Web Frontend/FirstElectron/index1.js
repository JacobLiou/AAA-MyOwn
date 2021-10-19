const {app, BrowserWindow} = require('electron')

let win

app.on('ready', function() {
    require('@electron/remote/main').initialize()

    win = new BrowserWindow({
        //fullscreen: true   //全屏
    //frame: false,   	//让桌面应用没有边框，这样菜单栏也会消失
    resizable: false,   //不允许用户改变窗口大小
    width: 800,         //设置窗口宽高
    height: 600,
    icon: iconPath,     //应用运行时的标题栏图标
    minWidth: 300,     // 最小宽度
    minHeight: 500,    // 最小高度
    // maxWidth: 300,    // 最大宽度
    // maxHeight: 600,    // 最大高度

    //运行对首选项的设置
    webPreferences:{
        backgroundThrottling: false,   //设置应用在后台正常运行
      nodeIntegration:true,     //设置能在页面使用nodejs的API
      contextIsolation: false,  //关闭警告信息
      

    //   enableWebSQL:true,
      //preload: path.join(__dirname, './preload.js')
    }
    })

    //主进程加载一个html -- 和渲染进程关联
    win.loadFile('index.html')

   // 设置为最顶层
  //win.setAlwaysOnTop(true)
  //win.loadURL(`www.baidu.com`) 可以让主进程打开文件或者一个链接

    win.on('closed', ()=>{
        //释放win
        win = null
    })
})

app.on('window-all-closed', ()=>{
    console.log('窗口全部关闭')
})