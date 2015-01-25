using UnityEngine;
using System.Collections;

public class LightController : MonoBehaviour {
	public GameObject player1Light;
	public GameObject player2Light;
	//public AudioClip die;
	// Use this for initialization
	void Start () {
		

		//playerLight.gameObject.GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		
		/*if (Input.GetButtonDown ("TurnOnLight")) {
			Debug.Log("Light is on!");
			player1Light.light.spotAngle += 3;
		}*/
		if(player1Light.light.spotAngle == 1){
			Application.LoadLevel("gameOver");
			//audio.PlayOneShot(die);
		}

		if(player2Light.light.spotAngle == 1){
			Application.LoadLevel("gameOver");
			//audio.PlayOneShot(die);
		}
		//Accelerate the shinking light over time
		//currentSpeed = currentSpeed + (lightAcc * Time.deltaTime);
		
		float scale = Time.deltaTime * 3;
		
		player1Light.light.spotAngle -= scale;
		player2Light.light.spotAngle -= scale;

	}
}
