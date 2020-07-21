using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CanvasButtons : MonoBehaviour,IPointerDownHandler
{
    /*Тут работа с кенвасом*/

    //bool StartStatus = false;  // проверка нажатия кнопки старт
    public new GameObject camera;
    public GameObject canvas;
     
    bool isPaused = false; //переменная состояния true - пауза, false - ход игры
    
    void Start()
    {
        Time.timeScale = 0; // установка времени ноль при запуске игры
    }

    public void OnPointerDown(PointerEventData eventData) //метод отслеживающий нажатие кнопки

    {
        Time.timeScale = 1; // запуск времени при нажатии

        if (isPaused == true)
        {
            //Time.timeScale = 1;
            canvas.GetComponent<Canvas>().enabled = false;
            isPaused = false;
        }
        camera.transform.position = new Vector3(0, 8.9f, -3f);//перемещение камеры 
        camera.transform.eulerAngles = new Vector3(67.694f, 0, 0);
        camera.GetComponent<Camera>().fieldOfView = 42.46f;//изменение компонента поле зрения камеры
        //canvas.GetComponent<Canvas>().enabled = false;

        foreach (Transform childs in canvas.transform)  // Поиск нужных дочерних элементов от объекта canvas с последующим ОТКСЛЮЧЕНИЕМ
        {
            if (childs.gameObject.CompareTag("Tx_NameGame") || childs.gameObject.CompareTag("Buttons")) // поиск по тегу
            {
                childs.gameObject.SetActive(false); // ОТКЛЮЧЕНИЕ при начале игры
            }
        }

    }

    void Update()
    {       
        /*ВНИМАНИЕ!  :-) я тута поломал твой искейп маленько
         Почему-то он перестал улавливать нажатия, после применения цикла foreach, 
         если захочешь вернуть как было, то просто закоменть два цикла foreach и раскоменть свою строчку с ...enabled = false
         */



        if (Input.GetKeyDown(KeyCode.Escape))//обработка нажатия клавиши Esc
        {            
            if (isPaused == false)
            {
                Debug.Log("pause");
                Time.timeScale = 0;//остановка хода времени
                //canvas.GetComponent<Canvas>().enabled = true;
                isPaused = true;

                foreach (Transform childs in canvas.transform)  // Поиск нужных дочерних элементов от объекта canvas с последующим ВКЛЮЧЕНИЕМ
                {
                    if (childs.gameObject.CompareTag("Tx_NameGame") || childs.gameObject.CompareTag("Buttons")) // поиск по тегу
                    {
                        childs.gameObject.SetActive(true); // ВКЛЮЧЕНИЕ элементов 
                    }
                }

            }
            else
            {
                Debug.Log("unpause");
                Time.timeScale = 1;//возобновление хода времени
                //canvas.GetComponent<Canvas>().enabled = false;
                isPaused = false;

            }
        }
    }
}
