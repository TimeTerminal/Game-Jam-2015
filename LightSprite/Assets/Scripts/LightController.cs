using UnityEngine;
using System.Collections;

public class LightController : MonoBehaviour {
	public GameObject playerLight;
	
	//public float currentSpeed = 0.0f;
	
	//public float lightAcc = 0.2f;
	
	
	// Use this for initialization
	void Start () {
		

		//playerLight.gameObject.GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetButtonDown ("TurnOnLight")) {
			Debug.Log("Light is on!");
			playerLight.light.spotAngle += 3;
		}
		
		//Accelerate the shinking light over time
		//currentSpeed = currentSpeed + (lightAcc * Time.deltaTime);
		
		float scale = Time.deltaTime * 3;
		
		playerLight.light.spotAngle -= scale;
	}
}
