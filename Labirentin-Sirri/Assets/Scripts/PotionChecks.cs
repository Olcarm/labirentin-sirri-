using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PotionChecks : MonoBehaviour
{
    [Header("Colors")]
    public Image img1;
    public Image img2;
    public Image img3;
    
    [Header("Potions")]
    public GameObject potYellow;
    Vector3 yellowPos;
    public GameObject potOrange;
    Vector3 orangePos;
    public GameObject potPink;
    Vector3 pinkPos;
    public GameObject potRed;
    Vector3 redPos;
    public GameObject potBlue;
    Vector3 bluePos;
    public GameObject potGreen;
    Vector3 greenPos;
    
    [Header("Menu")]
    public GameObject MenuUI;
    [Header("Tag Objects")]
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    [Header("Others")]
    public Button resetButton;
    public GameObject panzehir;
    public GameObject icme;
    public GameObject tarif;
    public GameObject check1;
    public GameObject check2;
    public GameObject check3;

    private int pot1;
    private int pot2;
    private int pot3;

    bool opt1 = false;
    bool opt2 = false;
    bool opt3 = false;
    void Start()
    {
        ResetOrderOfPots();
        yellowPos = potYellow.transform.position;
        orangePos = potOrange.transform.position;
        pinkPos = potPink.transform.position;
        redPos = potRed.transform.position;
        bluePos = potBlue.transform.position;
        greenPos = potGreen.transform.position;
        ChangeColors(img1, pot1, obj1);
        ChangeColors(img2, pot2, obj2);
        ChangeColors(img3, pot3, obj3);
        resetButton.onClick.AddListener(ReturnObjects);
    }
    void Update()
    {
        
    }
    void ChangeColors(Image imgg, int numb, GameObject obj)
    {
        if(numb == 0)
        {
            imgg.color = Color.yellow;
            obj.tag = "Sari";
            Console.WriteLine("Sari secildi");
        } 
        else if(numb == 1){
            Color _orange = new Color(1.0f, 0.64f, 0.0f);
            imgg.color = _orange;
            obj.tag = "Orange";    
            
        }

        else if(numb == 2)
        {
            Color32 _pink = new Color32(255, 0, 255, 255);
            imgg.color = _pink;
            obj.tag = "Pink";     
            
        }

        else if(numb == 3)
        {
            imgg.color = Color.red;
            obj.tag = "Red";  
            
        }

        else if(numb == 4)
        {
            imgg.color = Color.blue;
            obj.tag = "Blue"; 
            
        }

        else if (numb == 5)
        {
            imgg.color = Color.green;
            obj.tag = "Green";            
        }

    }

    public void ResetOrderOfPots()
    {
        pot1 = UnityEngine.Random.Range(0, 6);
        pot2 = UnityEngine.Random.Range(0, 6);
        pot3 = UnityEngine.Random.Range(0, 6);
    }
    public void ReturnObjects()
    {
        potYellow.transform.position = yellowPos;
        potOrange.transform.position = orangePos;
        potBlue.transform.position = bluePos;
        potPink.transform.position = pinkPos;
        potGreen.transform.position = greenPos;
        potRed.transform.position = redPos;
    }
    void OnTriggerEnter(Collider col)
    {
        
        if(opt1 == false)
        {
            if (col.gameObject.CompareTag(obj1.tag))
            {
                opt1 = true;
                check1.SetActive(true);
            }
            else
            {
                ResetOrderOfPots();
                ChangeColors(img1, pot1, obj1);
                ChangeColors(img2, pot2, obj2);
                ChangeColors(img3, pot3, obj3);
            }
        }
        else if(opt1 == true && opt2 == false)
        {
            if(col.gameObject.CompareTag(obj2.tag))
            {
                opt2 = true;
                check2.SetActive(true);
            }
            else
            {
                opt1 = false;
                check1.SetActive(false);
                ResetOrderOfPots();
                ChangeColors(img1, pot1, obj1);
                ChangeColors(img2, pot2, obj2);
                ChangeColors(img3, pot3, obj3);
            }
        }
        else if (opt1 == true && opt2 == true)
        {
            if (col.gameObject.CompareTag(obj3.tag))
            {
                opt3 = true;
                check3.SetActive(true);
                panzehir.SetActive(true);
                icme.SetActive(true);
                tarif.SetActive(false);
            }
            else
            {
                opt1 = false;
                opt2 = false;
                check1.SetActive(false);
                check2.SetActive(false);
                ResetOrderOfPots();
                ChangeColors(img1, pot1, obj1);
                ChangeColors(img2, pot2, obj2);
                ChangeColors(img3, pot3, obj3);
            }
        }
        ReturnObjects();
    } 
    
}
