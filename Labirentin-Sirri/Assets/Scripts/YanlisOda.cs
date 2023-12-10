using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class YanlisOda : MonoBehaviour
{
    Collider _collider;
    public GameObject ayarlar;
    void Start()
    {
        _collider = GetComponent<Collider>();
        _collider.isTrigger = true;
    }

    [System.Obsolete]
    void OnTriggerEnter(Collider other)
    {
        ayarlar.GetComponent<CiftKapiliOda>().SayiOlusturma();
    }
}

