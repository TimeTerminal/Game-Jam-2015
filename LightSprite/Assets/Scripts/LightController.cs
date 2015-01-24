using UnityEngine;
using System.Collections;

public class LightController : MonoBehaviour {

	GameObject playerLight;

	//public int startSize;

	//public float currentSpeed = 0.0f;

	//public float lightAcc = 0.2f;

	
	// Use this for initialization
	void Start () {

		playerLight = GameObject.Find ("Player Light");
		playerLight.gameObject.GetComponent<Light>();
		/*
		baseScale = playerLight.transform.localScale;
		//currentScale = baseScale * startSize;
		targetScale = baseScale * startSize;*/
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("TurnOnLight")) {
			Debug.Log("Light is on!");
			playerLight.light.spotAngle += 3;
		}

		//currentSpeed = currentSpeed + (lightAcc * Time.deltaTime);

		float scale = Time.deltaTime * 2;

		playerLight.light.spotAngle -= scale;
	}
}
