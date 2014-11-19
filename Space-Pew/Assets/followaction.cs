using UnityEngine;
using System.Collections;

public class followaction : MonoBehaviour
{
	private Vector3 velocity;
	[SerializeField]
	private float
		acceleration;
	[SerializeField]
	private float
		drag;
	[SerializeField]
	private Transform
		actionTransform;
	private Transform myTransform;


	void OnEnable ()
	{
		myTransform = GetComponent<Transform> ();
	}
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		myTransform.position = myTransform.position + velocity * Time.deltaTime;
	
	}
	void FixedUpdate ()
	{
		Vector3 accelerationVector;
		Vector3 myPos = myTransform.position;
		myPos.z = 0f;
		Vector3 action = actionTransform.position - myPos;
		action = action.normalized;
		accelerationVector = action * acceleration;
		velocity = velocity + accelerationVector * Time.fixedDeltaTime; 
		velocity = velocity - action * drag;
	}
}