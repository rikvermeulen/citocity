using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Drag : MonoBehaviour
{
    bool startDrag;
    void Start()
    {

    }

    void Update()
    {
        if(startDrag)
        {
            transform.position = Input.mousePosition;
        }
    }

    public void StartDragUI()
    {
        startDrag = true;
    }

    public void StopDragUI()
    {
        startDrag = false;
    }
}
