using UnityEngine;
using System.Collections;

public class CanExplode : MonoBehaviour
{


	// Use this for initialization
	void Start ()
	{
		StartCoroutine (ExplodeInTime (2.0f));
	}

	private IEnumerator ExplodeInTime (float seconds)
	{
		YieldInstruction wait = new WaitForSeconds (seconds);
		yield return wait;
		Explode ();
		yield return null;
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
			if (hits [destroyed].GetComponent<DieFromExplosion> () != null) {
				DestroyObject (hits [destroyed].gameObject);
			}
			destroyed ++;

		}
		DestroyObject (gameObject);
	}

}
	
// Update is called once per frame

