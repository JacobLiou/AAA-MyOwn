var c2 = document.getElementById("c2");
var ctx2 = c2.getContext('2d');

var imgs = new Image();
imgs.src = "\云原生开发 未来开发者 技术潮流.png";
imgs.onload = function(){
    ctx2.drawImage(this, 0 ,0 );

}

//// 涂层绘制到顶层(即覆盖膜)  canvas1
var c1 = document.getElementById('c1');
ctx1 = c1.getContext('c1');
ctx1.fillStyle = "lightGray";
ctx1.fillRect(0, 0, 960, 1440);

var good = document.getElementById('good');
good.addEventListener(onclick, () => {
    console.log("CLick");
})

