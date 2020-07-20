﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CanvasButtons : MonoBehaviour,IPointerDownHandler
{
    /*Тут работа с кенвасом*/

    bool StartStatus = false;  // проверка нажатия кнопки старт
    public new GameObject camera;
    public GameObject canvas;
    bool isPaused = false; //переменная состояния true - пауза, false - ход игры
    
    public void OnPointerDown(PointerEventData eventData) //метод отслеживающий нажатие кнопки

    {
        if (isPaused == true)
        {
            Time.timeScale = 1;
            canvas.GetComponent<Canvas>().enabled = false;
            isPaused = false;
        }
        camera.transform.position = new Vector3(0, 8.9f, -3f);//перемещение камеры 
        camera.transform.eulerAngles = new Vector3(67.694f, 0, 0);
        camera.GetComponent<Camera>().fieldOfView = 42.46f;//изменение компонента поле зрения камеры
        canvas.GetComponent<Canvas>().enabled = false;
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))//обработка нажатия клавиши Esc
        {
            if (isPaused == false)
            {
                Debug.Log("pause");
                Time.timeScale = 0;//остановка хода времени
                canvas.GetComponent<Canvas>().enabled = true;
                isPaused = true;

            }
            else
            {
                Debug.Log("unpause");
                Time.timeScale = 1;//возобновление хода времени
                canvas.GetComponent<Canvas>().enabled = false;
                isPaused = false;

            }
        }
    }
}
