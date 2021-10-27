using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour {

	public float velocidadUp = 3.5f;
	void Start () {
	}

	void Update () {
		transform.Translate (Vector3.down * velocidadUp * Time.deltaTime);
	}
	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			Moviemiento player = other.GetComponent<Moviemiento > ();

			player.disparoTripleOn ();


			Destroy (this.gameObject);
		}
			
	}

}
