using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaeyrMove : MonoBehaviour
{
    
    public GameObject obj; // объект игрока
    public GameObject health; // объект линии здоровья
    public float MoveSpeed = 2f; // скорость передвижения

    // Update is called once per frame
    void Update()
    {
        /* нажатие кнопок */
        if (Input.GetKey(KeyCode.UpArrow))
        {
            obj.transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
            health.transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            obj.transform.Translate(-Vector3.forward * MoveSpeed * Time.deltaTime);
            health.transform.Translate(-Vector3.forward * MoveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            obj.transform.Translate(-Vector3.right * MoveSpeed * Time.deltaTime);
            health.transform.Translate(-Vector3.right * MoveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            obj.transform.Translate(Vector3.right * MoveSpeed * Time.deltaTime);
            health.transform.Translate(Vector3.right * MoveSpeed * Time.deltaTime);
        }

    }
}
