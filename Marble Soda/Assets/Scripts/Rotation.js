#pragma strict
public var speed : int = 1;

function Update () {

	transform.Rotate(0,speed,0);
}