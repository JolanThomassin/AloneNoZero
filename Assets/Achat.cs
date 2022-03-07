using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achat : MonoBehaviour {

	private bool InZone = false;

	private void OnTriggerEnter2D(Collider2D other)
	{
		InZone = true;
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		InZone = false;
	}

	private void Update()
    {
		if (Input.GetKeyDown(KeyCode.E))
		{
			if (InZone == true)
			{
				if (CharacterController2D.instance.argent >= 50)
				{
					CharacterController2D.instance.argent -= 50;
				}
			}
		}
	}
}
