using UnityEngine;
using System.Collections;

public class BayrakCheck : MonoBehaviour {
	public Karakter oyuncu;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D () {
		oyuncu.BayrakAlindi();
		Destroy (gameObject);
		
	}

}
