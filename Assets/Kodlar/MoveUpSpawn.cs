using UnityEngine;
using System.Collections;

public class MoveUpSpawn : MonoBehaviour {

	public Transform player;
	public float hiz;
	public float maxY;
	public float minY;
	public int yon;
	void Start () {
		minY=(int) transform.position.y;
		maxY =(int) transform.position.y + 5;
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Vertical");

		if(maxY==(int)transform.position.y )
		{
		
		transform.localScale = new Vector3 (1f, 1f, 1f);
			yon = yon * -1;

		}
		if (minY>transform.position.y ) 
		{

			transform.localScale = new Vector3 (1f, 1f, 1f);
			yon = yon * -1;

		}





		transform.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,yon*hiz);




}
}