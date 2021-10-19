
const express = require("express"); //引入express模块
const path = require("path"); //引入磁盘路径模块
const app = express();
const port = 3000; //端口
const host = "127.0.0.1"; //主机
app.use(express.static(path.resolve(__dirname, "./client"))); //设置要开启服务的路径
 
app.listen(port, host, () => {
  //监听服务
  console.log(`客户端服务器为:http://${host}:${port}`);
});