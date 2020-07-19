using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bots : MonoBehaviour
{

    public GameObject pl;
    public float speed = 5;

    // Update is called once per frame
    void Update()
    {
        transform.position += (pl.transform.position - transform.position) * (speed * Time.deltaTime);
    }
}
