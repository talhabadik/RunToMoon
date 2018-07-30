using UnityEngine;
using System.Collections;

public class YıldızCheck : MonoBehaviour {
	public Karakter oyuncu;
	// Use this for initialization
	void Start () {
		oyuncu = GameObject.FindGameObjectWithTag("Player").GetComponent<Karakter>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.name == "Karekter") {
			oyuncu.YildizAlindi ();
			Destroy (gameObject);
		
		}
	}




}
