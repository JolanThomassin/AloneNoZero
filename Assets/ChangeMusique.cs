using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMusique : MonoBehaviour
{
    public AudioClip nouvelleMusique;

    private void Start()
    {
        ScriptMusique.instance.ChangerMusique(nouvelleMusique);
    }
}
