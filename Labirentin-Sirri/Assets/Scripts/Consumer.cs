using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Consumer : MonoBehaviour
{
    Collider _collider;
    public GameObject MenuUI;
    public GameObject Message;
    public GameObject Colors;
    public GameObject icme;
    void Start()
    {
        _collider = GetComponent<Collider>();
        _collider.isTrigger = true;
    }

    void OnTriggerEnter(Collider other)
    {
        Panzehir panzehir = other.GetComponent<Panzehir>();
        if(panzehir != null && !panzehir.IsFinished) {
            panzehir.Consume();
            MenuUI.SetActive(true);
            Message.SetActive(true);
            Colors.SetActive(false);
            icme.SetActive(false);
        }
    }
}
