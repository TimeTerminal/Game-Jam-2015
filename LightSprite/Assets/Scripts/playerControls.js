#pragma strict

var moveLeft : KeyCode;
var moveRight : KeyCode;
var moveUp : KeyCode;
var moveDown : KeyCode;

var speed : float = 10;


function Update () {

	if (Input.GetKey(moveLeft)) {
		rigidbody2D.velocity.x = speed * -1;
	}
	else if (Input.GetKey(moveRight)) {
		rigidbody2D.velocity.x = speed;
	}
	else if (Input.GetKey(moveUp)) {
		rigidbody2D.velocity.y = speed;
	}
	else if (Input.GetKey(moveDown)) {
		rigidbody2D.velocity.y = speed * -1;
	}
	else {

		rigidbody2D.velocity.x = 0;
		rigidbody2D.velocity.y = 0;
	}

}

