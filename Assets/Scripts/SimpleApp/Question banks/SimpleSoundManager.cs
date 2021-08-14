using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSoundManager : MonoBehaviour
{
    public static AudioClip incorrectSound;
    static AudioSource audioSrc;

    void Start()
    {
        incorrectSound = Resources.Load<AudioClip>("sounds/incorrectSound");
        audioSrc = GetComponent<AudioSource>();
    }
    public static void playIncorrectSound()
    {
        audioSrc.PlayOneShot(incorrectSound);
    }
}
