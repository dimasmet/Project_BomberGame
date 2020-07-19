using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaeyrMove : MonoBehaviour
{
    public GameObject obj;
    public float MoveSpeed = 2f;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
            obj.transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            obj.transform.Translate(-Vector3.forward * MoveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            obj.transform.Translate(-Vector3.right * MoveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            obj.transform.Translate(Vector3.right * MoveSpeed * Time.deltaTime);

    }
}
