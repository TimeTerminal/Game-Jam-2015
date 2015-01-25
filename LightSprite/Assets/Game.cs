using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

	public void StartGame() {
				Debug.Log ("Clicked me");
		Application.LoadLevel ("LightSpriteGame");
		}
}
