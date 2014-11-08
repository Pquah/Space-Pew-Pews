using UnityEngine;
using System.Collections;

public class CanDropBomb : MonoBehaviour
{
	[SerializeField]
	private GameObject
		bombPrefab;

	private bool dropBomb;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		dropBomb = Input.GetButtonUp ("DropBomb");
	}

	void FixedUpdate ()
	{
		if (dropBomb) {
			Instantiate (bombPrefab, transform.position, Quaternion.identity);
		}
	}
}
