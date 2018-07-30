using UnityEngine;
using System.Collections;
using UnityEngine.UI;//bunu skor tabelamız için import ediyoruz

public class Karakter : MonoBehaviour {
	public Text score;
	public Text GameOverText;
	public Text a;


	public float hiz,ziplamaGücü,hizsensor;
	public bool yerde=true,kosma;
	Rigidbody2D agirlik;

	public bool bayrak=false;
	public bool yildiz=false;
	public Animator anim;

	public int coin;
	public int yon=1;
	


	void Start () {
		agirlik = GetComponent<Rigidbody2D> ();
		coin = 0;
	}
	

	void Update () {
		float h = Input.GetAxis ("Horizontal");
		

		
		if (Input.GetKeyDown (KeyCode.Space) && yerde) {
			yerde = false;
			agirlik.AddForce (Vector3.up * ziplamaGücü);
			anim.SetBool ("ziplama", true);
		}

		if (Input.GetMouseButtonDown (0) && yerde) {
		
			yerde = false;
			agirlik.AddForce (Vector3.up * ziplamaGücü);
			anim.SetBool ("ziplama", true);
		}



		float sensor = Input.acceleration.x;

		a.text = sensor.ToString ();

		if (sensor < -0.1) {//telefonu sola doğru çevirdiğimizde olacaklar için

			agirlik.velocity = new Vector2 (sensor * hizsensor, agirlik.velocity.y);
			anim.SetBool ("Kosma", true);
			transform.localScale = new Vector3 (-0.7f, 0.7f, 1);
			yon = -1;


		} else if (sensor > 0.1) {////telefonu sağa doğru çevrildiğinde olacaklar için
			agirlik.velocity = new Vector2 (sensor * hizsensor, agirlik.velocity.y);
			anim.SetBool ("Kosma", true);
			transform.localScale = new Vector3 (0.7f, 0.7f, 1);
			yon = 1;
		}else {
			anim.SetBool("Kosma",false);
		}




		if(Input.GetKey(KeyCode.D)){
			agirlik.velocity = new Vector2 (h * hiz,agirlik.velocity.y);
			anim.SetBool("Kosma",true);
			transform.localScale = new Vector3(0.7f,0.7f,1);
			yon=1;
			
		}
		else if(Input.GetKey(KeyCode.A)){
			agirlik.velocity = new Vector2 (h * hiz,agirlik.velocity.y);
			anim.SetBool("Kosma",true);
			transform.localScale = new Vector3(-0.7f,0.7f,1);
			yon=-1;

		}else{
			anim.SetBool("Kosma",false);
		}

		score.text = "Score:"+coin ;

	}




	
	public void Yerde ()
	{
		yerde = true;
		anim.SetBool ("ziplama", false);

	}

	
	public void BayrakAlindi(){
		bayrak = true;
		coin=coin+10;
		coinTopla (coin);
	
	}

	public void YildizAlindi(){
		yildiz = true;
		coin++;
		coinTopla (coin);
	}

	void coinTopla(int coin){
		 

	}





	
	



	}
	

	

		
		
	
	
		
		
		
	
	


