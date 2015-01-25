using UnityEngine;
using System.Collections;

public class SpawnLevel : MonoBehaviour {

	public GameObject obsPrefab;
	public GameObject LanternPrefab;

	GameObject newObs;
	GameObject newLntrn;
		
	int gridWidth = 12;
	int gridHeight = 6;

	bool LanternGrabbed = true;

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

	void Update(){
		if (LanternGrabbed == true) {

			newLntrn = Instantiate (LanternPrefab, new Vector3 (Random.Range (0, 18), Random.Range (0, 13), 0), Quaternion.identity) as GameObject;
			LanternGrabbed = false;
		} else {
			//Do nothing	
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
