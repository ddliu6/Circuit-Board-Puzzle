using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeGenerator : MonoBehaviour
{
    void Start()
    {
        GenerateCode();
    }

    void GenerateCode()
    {
        float time = SavedTimer.savedTime;
        Debug.Log(time);
        if (time < 30f)
            GetComponent<Text>().text = "DD1IU6";
        else if (time < 40f && time >= 30f)
            GetComponent<Text>().text = "G12E4T";
        else if (time < 50f && time >= 40f)
            GetComponent<Text>().text = "134D55";
        else if (time < 60f && time >= 50f)
            GetComponent<Text>().text = "5H4M17";
        else if (time >= 60f)
            GetComponent<Text>().text = "L05E12";
    }
}