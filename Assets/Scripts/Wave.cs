using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    /* Скрипт для работы с взрывной волной */

    public GameObject player;  // добавление ссылки на игрока, для возможности обратиться к его свойствам

    void OnTriggerEnter(Collider other) // функция определения пересечения тригером
    {
        if (other.gameObject.CompareTag("Player")) // определения игрока по тегу
        {
            print("Игрок коснулся волны");
            player.GetComponent<PlayerScripts>().health -= 1; // уменьшения значения переменной в скрипте игрока
            player.GetComponent<PlayerScripts>().OutputHealth(); // вызов функции ввыода в консоль
            //player.GetComponent<PlayerScripts>().ColorHealth(); // Смена цвета у линии здоровья
            

        }

        if (other.gameObject.CompareTag("LightBlock")) // поиск деревянных боксов
        {
            print("Волна пересеклась с блоком");
            Destroy(other.gameObject);// уничтожение бокса
        }

    }

}
