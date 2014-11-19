using UnityEngine;
using System.Collections;

public class CanDropBomb : MonoBehaviour
{
	[SerializeField]
	private GameObject
		bombPrefab;

	private bool dropBomb;
	private Rigidbody2D myrigidbody2D;
	[SerializeField]
	private float
		speed;

	void OnEnable ()
	{
		myrigidbody2D = GetComponent<Rigidbody2D> ();
	}
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
			GameObject bomb = Instantiate (bombPrefab, transform.position, Quaternion.identity) as GameObject;
			Rigidbody2D bombrigidbody = bomb.GetComponent<Rigidbody2D> ();
			bombrigidbody.AddForce (myrigidbody2D.velocity * speed);
		
		}
	}
}
