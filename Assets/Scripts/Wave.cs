﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    /* Скрипт для работы с взрывной волной */

    public GameObject player;  // добавление ссылки на игрока, для возможности обратиться к его свойствам
    public GameObject objHealth;
    public float dist = 0.5f;

    Color color;
    void OnTriggerEnter(Collider other) // функция определения пересечения тригером
    {
        if (other.gameObject.CompareTag("wall"))
        {

            if (dist >= Vector3.Distance(transform.position, other.gameObject.transform.position))
            {
                dist = Vector3.Distance(transform.position, other.gameObject.transform.position); //+ 0.15f;
            }
            GetComponent<Transform>().localScale = new Vector3(0.3f, dist, 0.3f);
            print("Волна пересеклась со стеной, дистанция " + dist);
        }
        if (other.gameObject.CompareTag("LightBlock"))
        {
            if (dist >= Vector3.Distance(transform.position, other.gameObject.transform.position))
            {
                dist = Vector3.Distance(transform.position, other.gameObject.transform.position); //+ 0.15f;
            }
            GetComponent<Transform>().localScale = new Vector3(0.3f, dist, 0.3f);
            print("Волна пересеклась с блоком, дистанция " + dist);
            Destroy(other.gameObject);
        }

        
        if (other.gameObject.CompareTag("Player")) // определения игрока по тегу
        {
            if (other.gameObject.name == "second player")
            {
                other.gameObject.GetComponent<second_playerScript>().DecreaseHealth();
                print("Игрок 2 коснулся волны");
            }
            else
            {
                print("Игрок 1 коснулся волны");
                other.gameObject.GetComponent<PlayerScripts>().DecreaseHealth(); // уменьшения значения переменной в скрипте игрока           
                foreach (Transform child in transform)
                {
                    // child.GetComponent<MeshRenderer> ().material.color = new Color ()
                }
                //objHealth.GetComponent<MeshRenderer>().sharedMaterial.color = new Color(0f, 0f, 0f);
            }
        }

        if (other.gameObject.CompareTag("LightBlock")) // поиск деревянных боксов
        {
            print("Волна пересеклась с блоком");
            Destroy(other.gameObject);// уничтожение бокса
        }

    }

}
