using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CanvasButtons : MonoBehaviour,IPointerDownHandler
{
    /*Тут работа с кенвасом*/

    public bool StartStatus = false;  // проверка нажатия кнопки старт
    public new GameObject camera;
    public GameObject canvas;
    bool isPaused = false;
    
    public void OnPointerDown(PointerEventData eventData)

    {
        if (isPaused == true)
        {
            Time.timeScale = 1;
            canvas.GetComponent<Canvas>().enabled = false;
            isPaused = false;
        }
        camera.transform.position = new Vector3(0, 8.83f, -5.83f);
        camera.GetComponent<Camera>().fieldOfView = 42.46f;
        canvas.GetComponent<Canvas>().enabled = false;
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            print("pause");
            if (isPaused == false)
            {
                Debug.Log("pause");
                Time.timeScale = 0;
                canvas.GetComponent<Canvas>().enabled = true;
                isPaused = true;

            }
            else
            {
                Debug.Log("unpause");
                Time.timeScale = 1;
                canvas.GetComponent<Canvas>().enabled = false;
                isPaused = false;

            }
        }
    }
}
