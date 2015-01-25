using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {
	public AudioClip die;
	// Use this for initialization
	void Start () {
		audio.PlayOneShot(die);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
