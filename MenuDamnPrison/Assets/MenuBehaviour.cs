using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBehaviour : MonoBehaviour
{
    public void LoadLevel (int i)
    {
        Application.LoadLevel(i);
    }

    public void PlaySelect(AudioClip clip)
    {
        AudioSource audio = Object.FindObjectOfType<AudioSource>() as AudioSource;
        audio.PlayOneShot(clip);
    }
}
