using UnityEngine;
using System.Collections;

public class CanExplode : MonoBehaviour
{


	// Use this for initialization
	void Start ()
	{
		Explode ();
	}

	private void Explode ()
	{
		//declaring variable
		//type		 name
		Collider2D[] hits;
		hits = Physics2D.OverlapCircleAll ((Vector2)transform.position, 3f);
		Debug.Log (hits.Length);
		/*if (hits.Length > 0) {
			Debug.Log ("I hit something!");
			DestroyObject (hits [0].gameObject);
		}*/
		int destroyed;
		destroyed = 0;
		
		while (destroyed<hits.Length) {
			DestroyObject (hits [destroyed].gameObject);
			destroyed ++;
		}
	}
}
	
// Update is called once per frame

