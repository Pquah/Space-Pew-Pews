using UnityEngine;
using System.Collections;

public class MovementTowardsPlayer : MonoBehaviour
{
	[SerializeField]
	private float
		speed;
	private float horizontalDirection = 0f;
	private Rigidbody2D myRigidBody2D;

	// Use this for initialization
	void OnEnable ()
	{
		myRigidBody2D = GetComponent<Rigidbody2D> ();

	}

	void Start ()
	{
		StartCoroutine (UpdateDirection ());

	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		Vector2 enemyForce = new Vector2 (horizontalDirection, 1f) * speed * Time.fixedDeltaTime;
		myRigidBody2D.AddRelativeForce (enemyForce);
	}

	IEnumerator UpdateDirection ()
	{
		while (true) {
			int directionChoice = Random.Range (0, 2);
			if (directionChoice == 0) {
				horizontalDirection = -1f;
			} else {
				horizontalDirection = 1f;
			}
			yield return new WaitForSeconds (Random.Range (1f, 5f));
		}
	}
}
