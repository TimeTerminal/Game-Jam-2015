#pragma strict


var planeBounds : MeshCollider;

var Player01 : Transform;



function Update () {
	
	if(Player01.rigidbody2D.position.x > planeBounds.bounds.size.x/2) {
		Player01.rigidbody2D.position.x = planeBounds.bounds.size.x/2;
	} else if (Player01.rigidbody2D.position.y > planeBounds.bounds.size.y/2) {
		Player01.rigidbody2D.position.y = planeBounds.bounds.size.y/2;
	} else if(Player01.rigidbody2D.position.x < planeBounds.bounds.size.x/2*-1) {
		Player01.rigidbody2D.position.x = planeBounds.bounds.size.x/2*-1;
	} else if (Player01.rigidbody2D.position.y < planeBounds.bounds.size.y/2*-1) {
		Player01.rigidbody2D.position.y = planeBounds.bounds.size.y/2*-1;
	}
	/*print(Player01.rigidbody2D.position.x);
	print(Player01.rigidbody2D.position.y);
	print(planeBounds.bounds.size.x/2);
	print(planeBounds.bounds.size.y/2);
	print(planeBounds.bounds.center);*/
}