using UnityEngine;
using System.Collections;

public class SpawnLevel : MonoBehaviour {

	public GameObject wallPrefab;
	public GameObject obsPrefab;

	GameObject newWall;
	GameObject newObs;
		
	int gridWidth = 12;
	int gridHeight = 6;

	public int obsCount;
	public float PercentSpawn;

	int[] numObs;

	// Use this for initialization
	void Start () {

		//numObs = new int[obsCount];

		Random.seed = (int)System.DateTime.Now.Ticks;

		int wallHeight;
		int obsHeight;

		int obsCounter = 0;
		int currentISlot = 0;
		int currentJSlot = 0;
		  
		//Iterate through and spawn a matrix of cube walls
		//if(obsCounter < obsCount){
		//while(obsCounter < obsCount){
			for (int i = 0; i < gridWidth; i++) //row
			{
				for(int j = 0; j < gridHeight; j++)//column
				{


						if(randomBoolean() == true){
						//i += 3;
						//j += 3;
						newWall = Instantiate(wallPrefab, new Vector3 (i, j, 0), Quaternion.identity) as GameObject;
						newWall.transform.parent = gameObject.transform;
						wallHeight = j;
						newWall.transform.position +=new Vector3(i + 1, wallHeight + 1, 0); //THIS LINE

						obsCounter++;
						
					}
				}
				
			}
		//}

		//Iterate through and spawn a matrix of obstcales to block the player
		/*for (int i = 0; i < gridWidth; i++) //row
		{
			for(int j = 0; j < gridHeight; j++){

				newObs = Instantiate(obsPrefab, new Vector3 (i, j, 0), Quaternion.identity) as GameObject;
				newObs.transform.parent = gameObject.transform;
				obsHeight = j;
				newObs.transform.position+=new Vector3(i + 2, obsHeight + 2, 0); //THIS LINE

			}
			
			
		}*/

	}

	
	bool randomBoolean ()
	{



		if (Random.value <= PercentSpawn)
		{
			return true;
		}
		return false;
	}
}
