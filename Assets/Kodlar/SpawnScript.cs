using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] obje;
	public GameObject[] obje2;
	public GameObject lav;
	public bool isSpawned;
	public bool isMoveSpawned;
	public bool isLavaSpawned;
	public Transform player;
	int x1;
	int x2;
	int x;

	public GameObject meteor;
	int mx;//meteorun oluşacağı x
	public bool isMeteorSpawn;
	
	
	void Start () {
		isSpawned = false;
		isMoveSpawned = false;
		isMeteorSpawn = false;

	}
	
	
	void Update () {

		if (-17<player.position.y && player.position.y < 20 && !isSpawned) {
			Spawn ();
			isSpawned = true;
			isMoveSpawned=false;
		} else if (player.position.y<60 &&player.position.y > 20 && !isMoveSpawned) {

			MoveSpawn ();
			isMoveSpawned = true;
			isSpawned=false;
		}
		else if (player.position.y > 40 && !isMeteorSpawn) {
			MeteorSpawn ();
			isMeteorSpawn=true;

		}


}
	
	void Spawn(){
		int y = (int)player.position.y;


		x1 = Random.Range (-8,(int)player.position.x-4);
		x2 = Random.Range ((int)player.position.x + 4, 8);
		x = Random.Range (-8,8);

	


		int a = Random.Range (y + 2, y + 4);

		if (y % 2 != 0 && a % 2 == 0) {
			a++;
			
		} 
		else if (y % 2 == 0 && a % 2 != 0) {
			a++;

		}
	
	Vector3 spawnNoktasi = new Vector3 (x1,a,0);
		GameObject zeminIns = Instantiate(obje[Random.Range(0,obje.Length)],spawnNoktasi,Quaternion.identity) as GameObject;

		Vector3 spawnNoktasi2 = new Vector3 (x2,a,0);
		GameObject zeminIns2 = Instantiate(obje[Random.Range(0,obje.Length)],spawnNoktasi2,Quaternion.identity) as GameObject;

		Vector3 spawnNoktasi3 = new Vector3 (x,y*-1,0);
		GameObject zeminIns3 = Instantiate(obje[Random.Range(0,obje.Length)],spawnNoktasi3,Quaternion.identity) as GameObject;

		Destroy (zeminIns,8);//oluşturulan groundları yok etme
		Destroy (zeminIns2,8);
		Destroy (zeminIns3,8);
		Invoke("Spawn",2);//Invoke kendini tekrar eden fonksiyonlardır.
	}

	void MoveSpawn(){
		
		int y = (int)player.position.y;

		x1 = Random.Range (-10,(int)player.position.x-4);
		x2 = Random.Range ((int)player.position.x + 4,10);
		x = Random.Range (-10,10);
		
		int a = Random.Range (y + 2, y + 4);
		
		if (y % 2 != 0 && a % 2 == 0) {
			a++;
			
		} 
		else if (y % 2 == 0 && a % 2 != 0) {
			a++;
			
		}
		
		Vector3 spawnNoktasi = new Vector3 (x1,a,0);
		GameObject zeminIns = Instantiate(obje2[Random.Range(0,obje.Length)],spawnNoktasi,Quaternion.identity) as GameObject;
		
		Vector3 spawnNoktasi2 = new Vector3 (x2,a,0);
		GameObject zeminIns2 = Instantiate(obje2[Random.Range(0,obje.Length)],spawnNoktasi2,Quaternion.identity) as GameObject;
		
		Vector3 spawnNoktasi3 = new Vector3 (x,y-2,0);
		GameObject zeminIns3 = Instantiate(obje2[Random.Range(0,obje.Length)],spawnNoktasi3,Quaternion.identity) as GameObject;
		
		Destroy (zeminIns,6);//oluşturulan groundları yok etme
		Destroy (zeminIns2,6);
		Destroy (zeminIns3,6);
		Invoke("MoveSpawn",2);//Invoke kendini tekrar eden fonksiyonlardır.
	}
	
	
	void MeteorSpawn(){
		
		mx = Random.Range (-10, 10);
		
		Vector3 spawnNoktasi = new Vector3 (mx,59,0);
		GameObject zeminIns = Instantiate(meteor,spawnNoktasi,Quaternion.identity) as GameObject;
		Destroy (zeminIns,10);
		Invoke("MeteorSpawn",6);
		
		
	}
}
