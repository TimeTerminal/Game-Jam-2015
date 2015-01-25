using UnityEngine;
using System.Collections;

public class LanternHit : MonoBehaviour {



	GameObject playerLight;
	
	//public float currentSpeed = 0.0f;
	
	//public float lightAcc = 0.2f;
	
	
	// Use this for initialization
	void Start () {
		
		playerLight = GameObject.Find ("Player Light");
		playerLight.gameObject.GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		
		/*if (Input.GetButtonDown ("TurnOnLight")) {
			Debug.Log("Light is on!");
			playerLight.light.spotAngle += 3;
		}
		
		//Accelerate the shinking light over time
		//currentSpeed = currentSpeed + (lightAcc * Time.deltaTime);
		
		float scale = Time.deltaTime * 2;
		
		playerLight.light.spotAngle -= scale;*/
	}


	void OnCollisionEnter2D(Collision2D collision){
		GameObject isHit = collision.gameObject;
		if (isHit.tag == "Player") {
			Debug.Log ("U hit a lanturn, have more light!");
			playerLight.light.spotAngle += 10;
			this.transform.position = new Vector3 (Random.Range (0, 18), Random.Range (0, 13), 0);
		}
	}

}
