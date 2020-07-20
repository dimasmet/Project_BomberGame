using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombs : MonoBehaviour
{
    public GameObject player; // игрок
    public GameObject[] bombs; // массив префабов бомб, для возможной реализации разных видов
    public GameObject ExWave; // взрывная волна

    List<GameObject> BombsList = new List<GameObject>();  // список бомб
    List<GameObject> ExWaveList = new List<GameObject>();  // список волн

    IEnumerator TriggerOn() // в данный момент не используется. попытка вкл/выкл триггера на бомбе, для реализации правильного движения игрока по бомбам
    {
        yield return new WaitForSeconds(0.5f);
        bombs[0].GetComponent<SphereCollider>().isTrigger = false;
    }

    IEnumerator ExplosionBomb(GameObject b) // корутина с таймиром на 3 секунды, получает на вход последнюю бомбу
    {
        yield return new WaitForSeconds(3f);
        ExWaveList.Add(Instantiate(ExWave, b.transform.position, Quaternion.Euler(0, 0, 90)));
        ExWaveList.Add(Instantiate(ExWave, b.transform.position, Quaternion.Euler(90, 0, 0)));
        ExWaveList[ExWaveList.Count - 1].transform.localScale = new Vector3(0.3f, 1.5f, 0.3f);
        ExWaveList[ExWaveList.Count - 2].transform.localScale = new Vector3(0.3f, 1.5f, 0.3f);

        Destroy(ExWaveList[ExWaveList.Count - 1], 1f);// Уничтожение двух волн после 3 секунд
        Destroy(ExWaveList[ExWaveList.Count - 2], 1f);
        Destroy(b); // Уничтожение бомбы после 3 секунд
        //BombsList.RemoveAt(i);
    } 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // создание бомб
        {      
            BombsList.Add(Instantiate(bombs[0], player.transform.position, Quaternion.identity)); //  инициализация бомб и добавление их в список
            StartCoroutine(ExplosionBomb(BombsList[BombsList.Count - 1])); // запуск куронтина

            //StartCoroutine(TriggerOn());
        }
    }

}
