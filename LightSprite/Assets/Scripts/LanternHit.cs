using UnityEngine;
using System.Collections;

public class LanternHit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision){
		GameObject isHit = collision.gameObject;
		if (isHit.name != "player") {
			this.transform.position = new Vector3 (Random.Range (0, 18), Random.Range (0, 13), 0);
		}
	}

}
