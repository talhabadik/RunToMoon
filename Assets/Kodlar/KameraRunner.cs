using UnityEngine;
using System.Collections;

public class KameraRunner : MonoBehaviour {
	public Transform player;
	public float xPos;
	public float yPos;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (player.position.x + xPos,player.position.y+yPos, -60);//
}
}