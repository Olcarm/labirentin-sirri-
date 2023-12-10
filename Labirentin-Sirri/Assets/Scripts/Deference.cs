using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Deference : MonoBehaviour
{
    public TextMeshProUGUI tm;
    public ImageCanvas imageCanvas;
    public int[] buttonAnswers;
    public int[] correctAnswers;


    public void ChangeImages()
    {
        if (buttonAnswers[imageCanvas.inc] == correctAnswers[imageCanvas.inc] && imageCanvas.inc < buttonAnswers.Length)
        {
            imageCanvas.ChangeImages();
            imageCanvas.inc++;
            imageCanvas.ShowResult(true);

        }

        else
        {
            Debug.Log("Yanlış");
            imageCanvas.ShowResult(false);
        }

            
        if (imageCanvas.inc == buttonAnswers.Length)
        {
            //kapıyı aç
            Debug.Log("bitti");       
        
        }
    }

    public void ChangeTexts()
    {
        tm.text = buttonAnswers[imageCanvas.inc + 1].ToString();
    }

}
