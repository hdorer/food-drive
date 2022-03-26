using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreMusicSelector : MonoBehaviour {
    [SerializeField] AudioClip[] songs;

    AudioSource aSource;

    void Start() {
        aSource = GetComponent<AudioSource>();

        int roll = Random.Range(0, songs.Length);
        aSource.clip = songs[roll];

        aSource.Play();
    }
}
