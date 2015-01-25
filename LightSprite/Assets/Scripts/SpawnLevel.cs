using UnityEngine;
using System.Collections;

public class SpawnLevel : MonoBehaviour {

	public GameObject obsPrefab;

	GameObject newObs;
		
	int gridWidth = 12;
	int gridHeight = 6;

	public float PercentSpawn;
	
	void Start () {

		int wallHeight;

		for (int i = 0; i < gridWidth; i++){
			for(int j = 0; j < gridHeight; j++){

				if(randomBoolean() == true){

				newObs = Instantiate(obsPrefab, new Vector3 (i, j, 0), Quaternion.identity) as GameObject;
				newObs.transform.parent = gameObject.transform;
				wallHeight = j;
				newObs.transform.position +=new Vector3(i + 1, wallHeight + 1, 0);

				
				}
			}
			
		}
	}

	
	bool randomBoolean ()
	{
		if (Random.value <= PercentSpawn){
			return true;
		}
		return false;
	}
}
