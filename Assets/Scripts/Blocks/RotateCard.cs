using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCard : MonoBehaviour
{
    float speed = 100f;

    void Start()
    {

    }


    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
