using UnityEngine;
using System.Collections;

public class MoveSpawnScript : MonoBehaviour {

	public float maxRightX;
	public float maxLeftX;
	public float minX;
	public float hiz;

	public int yon;
	
	void Start () {
		minX= transform.position.x;
		maxRightX = 10;
		maxLeftX = -2;
	}
	
	
	void Update () {
		float h = Input.GetAxis ("Horizontal");
		

		if (minX > 0) {
			if (transform.position.x > maxRightX) {
				yon = yon * -1;
				transform.localScale = new Vector3 (-1f, 1f, 1f);
			
			}
			if (transform.position.x < minX) {
				yon = yon * -1;
				transform.localScale = new Vector3 (1f, 1f, 1f);
			}
		}

		if (minX < 0) {
			if (transform.position.x > maxLeftX) {
				yon = yon * -1;
				transform.localScale = new Vector3 (-1f, 1f, 1f);
			}
			if (transform.position.x < minX) {
				yon = yon * -1;
				transform.localScale = new Vector3 (1f, 1f, 1f);
			}
		}



		transform.GetComponent<Rigidbody2D> ().velocity = new Vector2 (30f*hiz * yon, 0);



		//transform.Translate (new Vector3 (hiz * yon, 0, 0));
	}


	


	
	}

