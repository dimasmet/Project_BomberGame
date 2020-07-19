using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombs : MonoBehaviour
{
    public GameObject player;
    public GameObject[] bombs;
    public GameObject ExWave;

    List<GameObject> BombsList = new List<GameObject>();
    List<GameObject> ExWaveList = new List<GameObject>();

    IEnumerator TriggerOn()
    {
        yield return new WaitForSeconds(0.5f);
        bombs[0].GetComponent<SphereCollider>().isTrigger = false;
    }

    IEnumerator ExplosionBomb(GameObject b)
    {
        yield return new WaitForSeconds(3f);
        ExWaveList.Add(Instantiate(ExWave, b.transform.position, Quaternion.Euler(0, 0, 90)));
        ExWaveList.Add(Instantiate(ExWave, b.transform.position, Quaternion.Euler(90, 0, 0)));
        ExWaveList[ExWaveList.Count - 1].transform.localScale = new Vector3(0.3f, 1.5f, 0.3f);
        ExWaveList[ExWaveList.Count - 2].transform.localScale = new Vector3(0.3f, 1.5f, 0.3f);

        Destroy(ExWaveList[ExWaveList.Count - 1], 1f);
        Destroy(ExWaveList[ExWaveList.Count - 2], 1f);
        Destroy(b);
        //BombsList.RemoveAt(i);
    } 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {      
            BombsList.Add(Instantiate(bombs[0], player.transform.position, Quaternion.identity));
            StartCoroutine(ExplosionBomb(BombsList[BombsList.Count - 1]));

            
        }
    }

}
