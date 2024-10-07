using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvas_auto : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float standard_width = 1152f;
        float standard_height = 648f;       //��ʼ�߶�  
        float device_width = 0f;                //��ǰ�豸���  
        float device_height = 0f;               //��ǰ�豸�߶�  
        float adjustor = 0f;         //��Ļ��������  
        //��ȡ�豸���  
        device_width = Screen.width;
        device_height = Screen.height;
        //�����߱���  
        float standard_aspect = standard_width / standard_height;
        float device_aspect = device_width / device_height;
        //�����������  
        if (device_aspect < standard_aspect)
        {
            adjustor = standard_aspect / device_aspect;
        }

        CanvasScaler canvasScalerTemp = transform.GetComponent<CanvasScaler>();
        if (adjustor == 0)
        {
            canvasScalerTemp.matchWidthOrHeight = 1;
        }
        else
        {
            canvasScalerTemp.matchWidthOrHeight = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
