using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Chunk : MonoBehaviour {

	public float spawnTime;
	public float spawnDelay = 0;

	public Transform spawn1;

	private Vector3 spawnPos1;
	private Quaternion rotation1;
	//public List<Transform> Chunks = new List<Transform> ();
	public GameObject[] enemies;

	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("Spawn", spawnDelay, spawnTime);

		spawnPos1 = spawn1.position;
		rotation1 = new Quaternion (0, 180, 0, 0);
	}
	
	// Update is called once per frame
	void Spawn ()
	{
		//Vector3 disSpawn = new Vector3 (0, 0, 0);
		//Vector3 spawnPos = spawnPos1 + disSpawn;
		int enemyIndex = Random.Range(0, enemies.Length);
		Instantiate(enemies[enemyIndex], spawnPos1, rotation1);
	}
}
