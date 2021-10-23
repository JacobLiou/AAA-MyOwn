// import ImageCapture

const constraints = {
  video: {
    width: {
      min: 1280,
      ideal: 1920,
      max: 2560,
    },
    height: {
      min: 720,
      ideal: 1080,
      max: 1440,
    },
  },
};

const videoStream = await navigator.mediaDevices.getUserMedia(constraints);

// https://juejin.cn/post/6844904184643321870
// 页面中有一个 <video autoplay id="video"></video> 标签
const video = document.querySelector("#video");
video.srcObject = videoStream
//这样一个摄像头就绑定到了Video 标签 摄像头可以看到了

//停止摄像头
videoStream.getTracks().forEach((track) => {
    track.stop();
})

// //拍照
// const track = videoStream.getTracks()[0];
// var imageCapture = new ImageCapture(track);
// imageCapture.takePhoto();
