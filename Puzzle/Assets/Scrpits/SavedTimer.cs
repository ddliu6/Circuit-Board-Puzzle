using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SavedTimer : MonoBehaviour
{
    public static float savedTime = 0f;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
