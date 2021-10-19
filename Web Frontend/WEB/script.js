function sendAjax(){
    var fromData = new FormData();
    fromData.append('username', 'jasondoe');
    fromData.append('id', 123456);
    //创建xhr对象
    var xhr = new XMLHttpRequest();
    xhr.timeout = 3000;
    //设置响应格式
    xhr.responseType = "text";
    xhr.open('POST', '/server', true);
    xhr.onload = function(e) {
        if(this.status == 200 || this.status == 304){
            alert(this.responseText);

        }
    };

    xhr.ontimeout = function(e){

    };

    xhr.onerror = function(e){
        console.error(e);
    };

    xhr.upload.onprogress = function(e) {

    };

    xhr.send(formData);
}

let p = new Promise((resolve, reject) => {
    //做一些异步操作
    setTimeout(function(){
        var num = Math.ceil(Math.random()*10); //生成1-10的随机数
        if(num<=5){
            resolve(num);
        }
        else{
            reject('数字太大了');
        }
    }, 2000);
    });
    p.then((data) => {
        console.log('resolved',data);
    },(err) => {
        console.log('rejected',err);
    }
    ); 


