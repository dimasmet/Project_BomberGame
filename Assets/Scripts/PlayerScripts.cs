using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScripts : MonoBehaviour
{
    private int health = 3; // количество жизней
    public float MoveSpeed = 2f;
    public Text TextHealth; // текстовое поле здоровья
    public Text TextWinLoss; // текст с информацией о победе или проигрыше

    void Start()
    {
        TextWinLoss.text = ""; // Изначально текст пустой, дабы не отображался
    }

    public void DecreaseHealth() // функция вычита здоровья, вызываемая при пересечении с волной в Скрипте Wave
    {
        health = health - 1; //
        print(health);
        UpdateText(); // функция обновление текста
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

    public void UpdateText() // функция обновление текста
    {
        TextHealth.text = "" + health.ToString() + " HP"; // вывод количества оставшихся жизней

        if (health == 0)  // если 0, то вывод сообщения о проигрыше
        {
            print("Вы проиграли!!!");
            TextWinLoss.text = "you are blown !!!";
            Time.timeScale = 0; // остановка времени
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
