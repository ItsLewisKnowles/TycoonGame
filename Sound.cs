using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour {

    private AudioSource audSource;
    public AudioClip Audio;

    void Awake()
    {
        audSource = GetComponent<AudioSource>();
    }

	public void ClickSound()
    {
        float vol = 1f;
        audSource.PlayOneShot(Audio, vol);
    }

}
