using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScripts : MonoBehaviour
{
    private int health = 3; // количество жизней
    public float MoveSpeed = 2f;
    //public GameObject objHealth; // объект линии здоровья

    public void DecreaseHealth() // функция вычита здоровья, вызываемая при пересечении с волной в Скрипте Wave
    {
        health = health - 1;
        print(health);
    }


    public void ColorHealth() // Смена цвета
    {
        //objHealth.GetComponent<MeshRenderer>().sharedMaterial.color = new Color(Random.Range(0,1f), Random.Range(0, 1f), Random.Range(0, 1f));
        /*Смена цвета пока не работает*/
    }

    void OnTriggerEnter(Collider other) // функция определения пересечения тригером
    {
        if (other.gameObject.CompareTag("BonusSpeed")) // определения бонуса 
        {
            print("Игрок подобрал бонус, СКОРОСТЬ увеличена!"); 
            other.gameObject.SetActive(false); //   выключение бонуса    
            MoveSpeed += 0.5f; // Увеличение скорости
            print(MoveSpeed);

        }
    }

    void Update()
    {
        /* нажатие кнопок */
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * MoveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Vector3.right * MoveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * MoveSpeed * Time.deltaTime);
        }

    }

}
