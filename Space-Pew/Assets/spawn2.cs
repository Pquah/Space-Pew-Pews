using UnityEngine;
using System.Collections;

public class spawn2 : MonoBehaviour
{
	[SerializeField]
	private GameObject
		enemyPrefab;
	
	// Use this for initialization
	void Start ()
	{
		StartCoroutine (EnemySpawn ());
	}
	
	// Update is called once per frame
	void Update ()
	{
	}
	IEnumerator EnemySpawn ()
	{
		while (true) {	
			
			{
				Instantiate (enemyPrefab, transform.position, Quaternion.identity);
			}
			
			yield return new WaitForSeconds (Random.Range (1f, 5f));
		}
		
		
	}
}
