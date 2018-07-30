using UnityEngine;
using System.Collections;

public class meteorScript : MonoBehaviour {
	public Karakter oyuncu;
	public GameObject gameOver;
	// Use this for initialization
	void Start () {
		oyuncu = GameObject.FindGameObjectWithTag("Player").GetComponent<Karakter>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.name == "Karekter") {
			oyuncu.transform.localScale = new Vector3 (-0.7f, 0.3f, 1);
			gameOver.SetActive(true);
			Time.timeScale=0;
			
		}
	}
}
