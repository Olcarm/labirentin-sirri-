using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CiftKapiliOda : MonoBehaviour
{
    int a, b, c, d,sonuc;
    int dogrucevap, yanliscevap;
    public TextMeshPro islemtext;
    public TextMeshPro dogrutext;
    public TextMeshPro yanlistext;


    // a+b*c-d;

    // Start is called before the first frame update
    void Start()
    {
        SayiOlusturma();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SayiOlusturma()
    {
        a = UnityEngine.Random.Range(0, 50);
        b = UnityEngine.Random.Range(0, 50);
        c = UnityEngine.Random.Range(0, 50);
        d = UnityEngine.Random.Range(0, 50);
        islemtext.text = (a + "+" + b + "*" + c + "-" + d);
         
        Islem();
        
        dogrucevap = sonuc;
        yanliscevap = (a + b) * c - d;

        dogrutext.text = dogrucevap.ToString();
        yanlistext.text = yanliscevap.ToString();


    }

    void Islem()
    {
        sonuc = a + (b * c) - d;
        

    }



    

}
