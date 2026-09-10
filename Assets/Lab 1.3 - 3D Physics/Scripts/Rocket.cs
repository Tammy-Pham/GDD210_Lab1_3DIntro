using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rocket : MonoBehaviour
{
	public bool EngineOn = false;
	public Rigidbody RocketRB;
	public float Thrust;
	public ParticleSystem Flames;
	public Text VelocityText;

	private void Update()
	{
		if(Input.GetKey(KeyCode.Space))
		{
			EngineOn = true;
			Flames.Play();
		}
		else
		{
			Flames.Stop();
			EngineOn = false;
		}

		VelocityText.text = (Mathf.Round(RocketRB.linearVelocity.y * 100f)/100f).ToString();
	}

	private void FixedUpdate()
	{
		if(EngineOn)
		{
			RocketRB.AddForce(new Vector3(0f, Thrust, 0f), ForceMode.Acceleration);
		}
	}

}
