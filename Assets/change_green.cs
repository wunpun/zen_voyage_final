using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class change_green : MonoBehaviour
{

    public void Start()
    {
        TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
        textmeshPro.color = new Color(255,255,255);
    }

    public void selected()
    {
        TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
        textmeshPro.color = new Color(0, 255, 0);
    }
    public void unselected()
    {
        TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
        textmeshPro.color = new Color(255,255,255);
    }
   

}
