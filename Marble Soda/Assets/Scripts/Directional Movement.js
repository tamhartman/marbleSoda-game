#pragma strict
var MPS : float = 1.00;

function Update () {
 var move : float = Time.deltaTime*MPS;
 transform.Translate(Vector3.down*move);
}