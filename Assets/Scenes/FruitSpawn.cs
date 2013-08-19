using UnityEngine;
using System.Collections;

public class FruitSpawn : MonoBehaviour {
	
	public float timer;
	public float ySpawn;
	public float screenW;
	public Transform Apple;
	public int spawnTrigger;
	protected float leftLimit;
	protected float rightLimit;

	// Use this for initialization
	void Start(){
		
			Debug.Log(Screen.width);
		    screenW=Screen.width;
		    leftLimit = GameObject.Find ("SpawnWallLeft").transform.position.x;
			rightLimit = GameObject.Find ("SpawnWallRight").transform.position.x;


	}
	
	// Update is called once per frame
	void Update () {
		ySpawn=Random.Range(leftLimit,rightLimit);
		timer +=Time.deltaTime;
		if (timer >=spawnTrigger) {
			timer = 0;
			Debug.Log("Spawn " + ySpawn);
			
		Instantiate(Apple, new Vector3(ySpawn,10,0f),Quaternion.identity);
				}
	

	}
}
