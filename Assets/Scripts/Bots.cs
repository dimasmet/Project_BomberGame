using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bots : MonoBehaviour
{
    /*Реализация движения ботов*/

    public GameObject pl;
    public float speed = 5;

    // Update is called once per frame
    void Update()
    {
        /*Временная команда слежки за игроком и движение по вектору в его сторону с определенной скоростью*/
        transform.position += (pl.transform.position - transform.position) * (speed * Time.deltaTime);
    }
}
