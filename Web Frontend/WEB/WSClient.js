const ws = new WebSocket("ws://127.0.0.1:8000"); //连接到客户端
 
//上线
ws.onopen = () => {
  ws.send("我上线啦");
};
//发送信息
ws.onmessage = (msg) => {
  const content = document.getElementById("content");
  content.innerHTML += msg.data + "<br>";
};
//报错
ws.onerror = (err) => {
  console.log(err);
};
 
//下线
ws.onclose = () => {
  console.log("close");
};