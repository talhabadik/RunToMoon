using UnityEngine;
using System.Collections;

public class GroundCheck : MonoBehaviour {

	public Karakter oyuncu;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D () {
		oyuncu.Yerde();
	

	}

	






}
