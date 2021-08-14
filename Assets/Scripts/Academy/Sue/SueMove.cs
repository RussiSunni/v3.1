using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sue : MonoBehaviour
{
    float Speed = 2.0f; //Speed at which object moves
    bool end = false;
    void Update()
    {
        if (transform.position.x > 0)
            end = true;
        if (transform.position.x < -20)
            end = false;

        //Moves the object right forever at the speed of 'Speed' 
        if (!end)
            transform.position += new Vector3(Speed * Time.deltaTime, 0, 0);
        else
            transform.position += new Vector3(Speed * Time.deltaTime * -1, 0, 0);
    }
}