using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasButtons : MonoBehaviour
{
    public bool StartStatus = false;
    public void StartGame()
    {
        Camera.main.transform.position = new Vector3(5f, 7f, 0);
        StartStatus = true;
    }

}
