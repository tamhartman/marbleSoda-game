#pragma strict
var OffscreenPos : float;
var MoveTo : float;


function Update () {
if (transform.position.y < OffscreenPos){
transform.position.y = MoveTo;
}
}