using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScripts : MonoBehaviour
{
    public int health = 3; // количество жизней
    public GameObject objHealth; // объект линии здоровья

    public void OutputHealth() // вывод в консоль
    {
        print("Здоровье ");
        print(health);
    }

    public void ColorHealth() // Смена цвета
    {
        objHealth.GetComponent<Renderer>().material.color = new Color(Random.Range(0,1f), Random.Range(0, 1f), Random.Range(0, 1f));
        /*Смена цвета пока не работает*/
    }

}
