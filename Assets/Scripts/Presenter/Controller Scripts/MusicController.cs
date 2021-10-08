using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour {

    public static MusicController insntace;

    private AudioSource audioSource;

	void Awake () {
        MakeSingleton();
        audioSource = GetComponent<AudioSource>();
    }

	void MakeSingleton()
    {
        if(insntace != null)
        {
            Destroy(gameObject);
        }
        else
        {
            insntace = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void PlayMusic(bool play)
    {
        if (play)
        {
            if (!audioSource.isPlaying)
                audioSource.Play();
        }
        else
        {
            if (audioSource.isPlaying)
                audioSource.Stop();
        }
    }

}
