using UnityEngine;
using System.Collections;

public class HaloBudge : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		light.range = Mathf.Abs(Mathf.Sin(Time.time)) + 1;
	}
}
