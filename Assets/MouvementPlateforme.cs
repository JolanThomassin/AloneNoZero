using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementPlateforme : MonoBehaviour
{
    [SerializeField] private Transform targetA, targetB;
    private float speed = 2f; //Change this to suit your game.
    private bool switching = false;
    void Update()
    {
        if (!switching)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetB.position, speed * Time.deltaTime);
        }
        else if (switching)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetA.position, speed * Time.deltaTime);
        }
        if (transform.position == targetB.position)
        {
            switching = true;
        }
        else if (transform.position == targetA.position)
        {
            switching = false;
        }
    }
}