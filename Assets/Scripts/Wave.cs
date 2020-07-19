using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public GameObject player;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            print("Игрок коснулся волны");
           player.GetComponent<PlayerScripts>().health -= 1;
           player.GetComponent<PlayerScripts>().OutputHealth();
        }

        if (other.gameObject.CompareTag("LightBlock"))
        {
            print("Волна пересеклась с блоком");
            Destroy(other.gameObject);
        }

    }

}
