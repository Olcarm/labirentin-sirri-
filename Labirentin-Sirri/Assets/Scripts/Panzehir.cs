using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panzehir : MonoBehaviour
{
    AudioSource _audioSource;

    public bool IsFinished = false;
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.playOnAwake = false;
        
    }

    [ContextMenu("Consume")]
    public void Consume()
    {
        if (!IsFinished)
        {
           _audioSource.Play();
            Destroy(this.gameObject);
            IsFinished = true;
        }
    }

}