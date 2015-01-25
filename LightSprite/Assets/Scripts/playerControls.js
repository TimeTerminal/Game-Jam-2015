#pragma strict

var moveLeft : KeyCode;
var moveRight : KeyCode;
var moveUp : KeyCode;
var moveDown : KeyCode;

var charLeft : Sprite;
var charRight : Sprite;
var charBottom : Sprite;
var charUp : Sprite;
var speed : int;

var player : Animator;

function Start (){
	player = GetComponent (Animator);
	//speed = Time.deltaTime
	speed = 2;
}

function Awake (){
	player = GetComponent (Animator);
}

function TurnAllStatesFalse ()
{
	player.SetBool ("ReleaseUp", false);
	player.SetBool ("ReleaseDown", false);
	player.SetBool ("ReleaseRight", false);
	player.SetBool ("ReleaseLeft", false);
	
	player.SetBool ("PressUp", false);
	player.SetBool ("PressDown", false);
	player.SetBool ("PressRight", false);
	player.SetBool ("PressLeft", false);
}

function Update () {

	//Left
	if (Input.GetKey(moveLeft) == true) {
		transform.position += Vector3.left * Time.deltaTime * speed;
		TurnAllStatesFalse ();
		player.SetBool ("PressLeft", true);
		/*transform.rigidbody2D.velocity.x = speed * -1;
		rigidbody.AddForce (Vector3.left,  -10);*/
	}
	else if (Input.GetKeyUp (moveLeft)){
		TurnAllStatesFalse ();
		player.SetBool ("ReleaseLeft", true);
	}
	
	//Right
	if (Input.GetKey (moveRight)) {
		
		TurnAllStatesFalse ();
		player.SetBool ("PressRight", true);
		transform.position += Vector3.right * Time.deltaTime * speed;
		//transform.rigidbody2D.velocity.x = speed * 1;
	}
	else if (Input.GetKeyUp (moveRight)){
		TurnAllStatesFalse ();
		player.SetBool ("ReleaseRight", true);
		//transform.rigidbody2D.velocity.x = speed * 1;
	}

	//Up
	if (Input.GetKey (moveUp)) {
		TurnAllStatesFalse ();
		player.SetBool ("PressUp", true);
		transform.position += Vector3.up * Time.deltaTime * speed;
	}
	else if (Input.GetKeyUp (moveUp)){
		TurnAllStatesFalse ();
		player.SetBool ("ReleaseUp", true);
	}
	
	//Down
	if (Input.GetKey (moveDown)) {
		transform.position += Vector3.down * Time.deltaTime * speed;
		TurnAllStatesFalse ();
		player.SetBool ("PressDown", true);
	}
	else if (Input.GetKeyUp (moveDown)){
		TurnAllStatesFalse ();
		player.SetBool ("ReleaseDown", true);
	}
	/* ============== */
	
	//Normal State
	else {
		rigidbody2D.velocity.x = 0;
		rigidbody2D.velocity.y = 0;
	}
}

/*function OnCollisionEnter(collision : Collision)
{
	var whohitme = collision.gameObject;
	if( whohitme.name == "lantern") {
		Destroy(whohitme);
	}
}
*/
