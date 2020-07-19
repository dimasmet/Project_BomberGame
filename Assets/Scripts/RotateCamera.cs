using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public GameObject Canvas;
    public float Speed_Cam = 5f;
    //int k = 0;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //if (Canvas.GetComponent<CanvasButtons>().StartStatus == false)
        //{
        //    transform.Rotate(0, Speed_Cam * Time.deltaTime, 0);
        //}
        //else
        //{
        //    if (k != 1)
        //    {
        //        transform.Translate(0, 0, 1f);
        //        k++;
        //    }
        //}
    }
}
