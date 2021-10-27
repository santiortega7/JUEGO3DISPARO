using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviemiento : MonoBehaviour
{
	// Start is called before the first frame update

	public float velocidad;

	public float movimientoHorizontal;
	public float movimientoVertical;
	[SerializeField]
	private bool powerUpvelocidad = false;
	//private bool disparotriple = false;

	//public GameObject laser;

	void Start()
	{
		velocidad = 2.0f;
	}

	// Update is called once per frame
	void Update()
	{
		//movimiento();
		//disparo();
		float Horizontal = Input.GetAxis ("Horizontal") * velocidad * Time.deltaTime;
		print (Horizontal);
		transform.Translate (Horizontal, 0, 0);
		aumentarVelocidad ();
	}

	void movimiento()
	{
		movimientoHorizontal = Input.GetAxis("Horizontal");
		transform.Translate(Vector3.right * velocidad * movimientoHorizontal * Time.deltaTime);

		movimientoVertical = Input.GetAxis("Vertical");
		transform.Translate(Vector3.up * velocidad * movimientoVertical * Time.deltaTime);

		if (transform.position.x>= 6.0f)
		{
			transform.position = new Vector3(6.0f, transform.position.y, -0.50f);
		}
		else if(transform.position.x <= -6.0f)
		{
			transform.position = new Vector3(-6.0f, transform.position.y, -0.50f);
		}
		else if(transform.position.y <= -4.0f)
		{
			transform.position = new Vector3(transform.position.x, -4.0f, -0.50f);
		}
		else if (transform.position.y >= 4.0f)
		{
			transform.position = new Vector3(transform.position.x, 4.0f, -0.50f);
		}
	}

	//void disparo()
	//{
	//if (disparotriple == true && Input.GetKey(KeyCode.Space))
	//{
	//		Instantiate(laser, transform.position + new Vector3(0, 0.5f, -3.08f), Quaternion.identity);
	//		Instantiate(laser, transform.position + new Vector3(0.2f,0, -3.08f), Quaternion.identity);
	//		Instantiate(laser, transform.position + new Vector3(-0.2f, 0, -3.08f), Quaternion.identity);
	//	}
	//	else if (Input.GetKey(KeyCode.Space))
	//	{
	//		
	//		Instantiate(laser, transform.position + new Vector3(0, 0.5f, -3.08f), Quaternion.identity);
	//}


//	}

	void aumentarVelocidad()
	{

		float horizontal = Input.GetAxis ("Horizontal");

		if (powerUpvelocidad == true) {

			transform.Translate (Vector3.right * velocidad * 5.0f * horizontal * Time.deltaTime);
		} else {
			transform.Translate (Vector3.right * velocidad *  horizontal * Time.deltaTime);


		}

	}

	public void Poweer()
	{
		powerUpvelocidad = true;
		StartCoroutine (powerDown());
	}



	IEnumerator powerDown()
	{
		yield return new WaitForSeconds (5.0f);
		powerUpvelocidad = false;
	}



}