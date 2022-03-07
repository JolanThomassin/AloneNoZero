using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMusique : MonoBehaviour
{
    private AudioSource piste01, piste02;
    private bool musiqueEnCours;

    public static ScriptMusique instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        piste01 = gameObject.AddComponent<AudioSource>();
        piste02 = gameObject.AddComponent<AudioSource>();
        musiqueEnCours = true;

        DontDestroyOnLoad(gameObject);
    }

    public void ChangerMusique(AudioClip nouvelleMusique)
    {
        if (musiqueEnCours)
        {
            piste02.clip = nouvelleMusique;
            piste02.Play();
            piste01.Stop();
        } else
        {
            piste01.clip = nouvelleMusique;
            piste01.Play();
            piste02.Stop();

        }

        musiqueEnCours = !musiqueEnCours; 

    }
}
