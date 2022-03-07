using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class leaveTalk : MonoBehaviour
{

	private bool InZone = false;

	public string sceneName;
	[SerializeField] private string newScenePassword;

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
				CharacterController2D.instance.scenePassword = newScenePassword;
				SceneManager.LoadScene(sceneName);
			}
		}
	}
}
