using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(PolygonCollider2D))]
public class SoundCtrl : MonoBehaviour {
    private AudioSource frazeClip;
    public bool repitable = false;
    private bool isPlayed = false;

    private void Awake()    {
        frazeClip = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)    {
        if (!isPlayed || repitable)        {
            frazeClip.Play();
            isPlayed = true;
        }
    }
}
