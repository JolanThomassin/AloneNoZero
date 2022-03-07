using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoTo : MonoBehaviour
{
    public string sceneName;
    [SerializeField] private string newScenePassword;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            CharacterController2D.instance.scenePassword = newScenePassword;
            SceneManager.LoadScene(sceneName);
        }
    }

}
