using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    /* Скрипт для работы с взрывной волной */

    public GameObject player;  // добавление ссылки на игрока, для возможности обратиться к его свойствам
    public GameObject objHealth;

    Color color;
    void OnTriggerEnter(Collider other) // функция определения пересечения тригером
    {
        if (other.gameObject.CompareTag("Player")) // определения игрока по тегу
        {
            print("Игрок коснулся волны");
            other.gameObject.GetComponent<PlayerScripts>().DecreaseHealth(); // уменьшения значения переменной в скрипте игрока           
            foreach (Transform child in transform)
            {
               // child.GetComponent<MeshRenderer> ().material.color = new Color ()
            }
            //objHealth.GetComponent<MeshRenderer>().sharedMaterial.color = new Color(0f, 0f, 0f);

        }

        if (other.gameObject.CompareTag("LightBlock")) // поиск деревянных боксов
        {
            print("Волна пересеклась с блоком");
            Destroy(other.gameObject);// уничтожение бокса
        }

    }

}
