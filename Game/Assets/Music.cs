using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] private AudioSource music;

    public void OnMusic()
    {
        music.Play();

    }

    public void OffMusic()
    {
        music.Stop();
    }
}
