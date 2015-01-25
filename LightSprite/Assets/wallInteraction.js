#pragma strict


function OnCollisionEnter2D (colInfo : Collision2D) {
	Debug.Log("something");
	if(colInfo.gameObject.tag == "Player"){
		Debug.Log("it Works");
	}
	
}