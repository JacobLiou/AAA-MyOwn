const webSocket = require('ws');

const ws = new webSocket.Server({port: 8000});
let clients = {};
let clientNum = 0;

ws.on("connection", (client) => {


    client.name = ++clientNum;
    clients[client.name] = client;

    //用户的聊天记录
    client.on("message", (msg) => {
        console.log("用户" + client.name + "是" + msg);
        //广播发出
        broadcast(client, msg);
    });
    //报错信息
    client.on("error", (err) => {
        if (err) {
        console.log(err);
        }
    });
    // 下线
    client.on("close", () => {
        delete clients[client.name];
        console.log("用户" + client.name + "下线了~~");
    });


});

function  broadcast(client, msg){
    for(var key in clients)
    {
        clients[key].send("用户" + client.name + "说：" + msg);
    }
}

