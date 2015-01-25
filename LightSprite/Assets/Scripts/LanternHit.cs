using UnityEngine;
using System.Collections;

public class LanternHit : MonoBehaviour {
	GameObject player1Light;
	GameObject player2Light;
	
	int score;
	
	public Font scoreFont;
	Rect textArea = new Rect (Screen.width/2,10,Screen.width,Screen.height);

	// Use this for initialization
	void Start () {
		score = 0;
		player1Light = GameObject.Find ("Player 1 Light");
		player1Light.gameObject.GetComponent<Light>();

		player2Light = GameObject.Find ("Player 2 Light");
		player2Light.gameObject.GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnGUI() {
		GUI.skin.font = scoreFont;
		GUI.Label (textArea, "Score " + score);
		
	}
	
	void OnCollisionEnter2D(Collision2D collision){
		GameObject isHit = collision.gameObject;
		if (isHit.tag == "Player1") {
			player1Light.light.spotAngle += 10;
			this.transform.position = new Vector3 (Random.Range (0, 18), Random.Range (0, 13), 0);
			score++;
		}
		if (isHit.tag == "Player2") {
			player2Light.light.spotAngle += 10;
			this.transform.position = new Vector3 (Random.Range (0, 18), Random.Range (0, 13), 0);
			score++;
		}

		if(isHit.name == "Obstacle"){
			this.transform.position = new Vector3(Random.Range (0, 18), Random.Range (0, 13), 0);
			
		}

	}
}
