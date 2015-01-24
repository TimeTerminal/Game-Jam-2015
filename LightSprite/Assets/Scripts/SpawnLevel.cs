using UnityEngine;
using System.Collections;

public class SpawnLevel : MonoBehaviour {

	public GameObject obsPrefab;
	GameObject newWall;
		
	int gridWidth = 12;
	int gridHeight = 6;
	int xSpacing = 1;

	// Use this for initialization
	void Start ()
	{
		int temp;
		
		for (int i=0; i < gridWidth; i++) //row
		{
			
			for(int j=0; j < gridHeight;j++)//column
			{
				newWall = Instantiate(obsPrefab, new Vector3 (i,j,0),Quaternion.identity) as GameObject;
				newWall.transform.parent =gameObject.transform;
				temp=j;
				newWall.transform.position+=new Vector3(i+1,temp+1,0); //THIS LINE
			}
			
			
		}
		gameObject.transform.position = new Vector3(0f,0f,0f); 
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
