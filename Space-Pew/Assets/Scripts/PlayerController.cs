using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


	[SerializeField]
	private float speed=1f;
	private float horizontalthrust=0f;
	private float verticalthrust=0f;

	private Rigidbody2D myrigidbody2d;

	void OnEnable () {
		myrigidbody2d = GetComponent<Rigidbody2D> ();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		horizontalthrust = Input.GetAxis ("Horizontal");
		verticalthrust = Input.GetAxis ("Vertical");
	
	}

	void FixedUpdate () {
		Vector2 force = speed * Time.fixedDeltaTime * new Vector2 (horizontalthrust, verticalthrust);
			//transform.position = transform.position + new Vector3 (speed * Time.fixedDeltaTime * horizontalthrust,0,0);
		myrigidbody2d.AddForce (force);

	}




}
