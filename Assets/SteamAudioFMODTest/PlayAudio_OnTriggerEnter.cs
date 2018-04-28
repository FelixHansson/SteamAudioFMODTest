using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio_OnTriggerEnter : MonoBehaviour
{
    private AudioSource mAudioSource;

    private void Awake()
    {
        mAudioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        mAudioSource.Play();
    }
}