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
	player.SetBool ("LeftKeyDown", false);
	player.SetBool ("RightKeyDown", false);
	player.SetBool ("UpKeyDown", false);
	player.SetBool ("DownKeyDown", false);
	
	player.SetBool ("LeftKeyUp", false);
	player.SetBool ("RightKeyUp", false);
	player.SetBool ("UpKeyUp", false);
	player.SetBool ("DownKeyUp", false);
}

function Update () {

	//Left
	if (Input.GetKey(moveLeft) == true) {
		transform.position += Vector3.left * Time.deltaTime * speed;
		TurnAllStatesFalse ();
		player.SetBool ("LeftKeyDown", true);
		/*transform.rigidbody2D.velocity.x = speed * -1;
		rigidbody.AddForce (Vector3.left,  -10);*/
	}
	else if (Input.GetKeyUp (moveLeft)){
		TurnAllStatesFalse ();
		player.SetBool ("LeftKeyUp", true);
	}
	
	//Right
	if (Input.GetKey (moveRight)) {
		
		TurnAllStatesFalse ();
		player.SetBool ("RightKeyDown", true);
		transform.position += Vector3.right * Time.deltaTime * speed;
		//transform.rigidbody2D.velocity.x = speed * 1;
	}
	else if (Input.GetKeyUp (moveRight)){
		TurnAllStatesFalse ();
		player.SetBool ("RightKeyUp", true);
		//transform.rigidbody2D.velocity.x = speed * 1;
	}

	//Up
	if (Input.GetKey (moveUp)) {
		TurnAllStatesFalse ();
		player.SetBool ("UpKeyDown", true);
		transform.position += Vector3.up * Time.deltaTime * speed;
	}
	else if (Input.GetKeyUp (moveUp)){
		TurnAllStatesFalse ();
		player.SetBool ("UpKeyUp", true);
	}
	
	//Down
	if (Input.GetKey (moveDown)) {
		transform.position += Vector3.down * Time.deltaTime * speed;
		TurnAllStatesFalse ();
		player.SetBool ("DownKeyDown", true);
	}
	else if (Input.GetKeyUp (moveDown)){
		TurnAllStatesFalse ();
		player.SetBool ("DownKeyUp", true);
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
