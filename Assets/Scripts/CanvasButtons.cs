using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasButtons : MonoBehaviour
{
    /*Тут работа с кенвасом*/

    public bool StartStatus = false;  // проверка нажатия кнопки старт
    public void StartGame()
    {
        Camera.main.transform.position = new Vector3(5f, 7f, 0); // плохая попытка смены положения камеры :)
        StartStatus = true;// 
    }

}
