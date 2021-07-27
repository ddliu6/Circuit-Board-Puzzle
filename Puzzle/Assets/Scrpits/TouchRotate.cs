using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotate : MonoBehaviour
{
    public int rotation;

    void Awake()
    {
        rotation = 0;
        RandomRotate();
    }

    public void Rotate()
    {
        if (!GameControl.instance.CheckWin())
        {
            transform.Rotate(0f, 0f, 90f);
            ++rotation;
            if (rotation > 3)
                rotation -= 4;
            GameControl.instance.CheckWin(); //check again
        } 
    }

    void RandomRotate()
    {
        int direction = Random.Range(1, 4); //1-3
        rotation += direction;
        transform.Rotate(0f, 0f, 90f * direction);
    }
}
