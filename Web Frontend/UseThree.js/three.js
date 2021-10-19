import * as THREE from "three"
const scene = new THREE.Scene();

const ambientLight = new THREE.AmbientLight(0xffffff, 0.6);
scene.add(ambientLight);

const diretionalLight = new THREE.DirectionalLight(0xffffff, 0.8);
diretionalLight.position.set(200, 500, 300);
scene.add(diretionalLight);

