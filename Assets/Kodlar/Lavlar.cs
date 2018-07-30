using UnityEngine;
using System.Collections;

public class Lavlar : MonoBehaviour {

	public Transform lav;
	public float y;
	public float hiz;
	public GameObject gameOver;
	public bool lavaUp;


	void Start () {
		lavaUp = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (lavaUp == true) {
			transform.Translate (0, y * hiz, 0);
			y++;

		} 
	if (transform.position.y > -25) {
			lavaUp=false;

		}
	}

	void OnTriggerEnter2D(Collider2D col){
		
		if (col.gameObject.name == "Karekter") {
			
			gameOver.SetActive(true);//görünmez olan bir objeyi görünür hale getirmek için kullanılır
			Time.timeScale=0;//Oyunu durdurmak için kullanılır
			lavaUp=false;
		}
}
}