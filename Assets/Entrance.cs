using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrance : MonoBehaviour
{
    public string entrancePassword;

    private void Start()
    {
        if (CharacterController2D.instance.scenePassword == entrancePassword)
        {
            CharacterController2D.instance.transform.position = transform.position;
            PlayerMovement.instance.goingLeft = false;
            PlayerMovement.instance.goingRight = false;
            Debug.Log("ENTER!");
        }
        else
        {
            Debug.LogWarning("WRONG PW");
        }

    }

}
