var sparks : GameObject;

function Start () {
 sparks.SetActive(false);
}
function OnTriggerEnter(){
 sparks.SetActive(true);
}
function OnTriggerExit(){
 sparks.SetActive(false);
}
