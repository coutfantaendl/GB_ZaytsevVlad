using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip[] footstepSounds;

    public AudioSource audioSource => GetComponent<AudioSource>();

    public void PlayFootstepSound()
    {
        audioSource.PlayOneShot(footstepSounds[0]); 
    }
    


}
