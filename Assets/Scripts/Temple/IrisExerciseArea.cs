using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IrisExerciseArea : MonoBehaviour
{
    private GameObject tb1, tb2, tb3, tb4, blue, red, green, yellow;
    Vector3 tb1Position, tb2Position, tb3Position, tb4Position;


    // Start is called before the first frame update
    private void Start()
    {

        // set target block positions
        // tb1Position.x = -5.732f;
        // tb1Position.y = -2.503f;
        // tb1 = GameObject.Find("target_block-1");
        // tb1.transform.position = tb1Position;

        // tb2Position.x = -3.873f;
        // tb2Position.y = -2.503f;
        // tb2 = GameObject.Find("target_block-2");
        // tb2.transform.position = tb2Position;

        // tb3Position.x = -2.014f;
        // tb3Position.y = -2.503f;
        // tb3 = GameObject.Find("target_block-3");
        // tb3.transform.position = tb3Position;

        // tb4 = GameObject.Find("target_block-4");


        blue = GameObject.Find("blue");
        if (Progress.blue == false)
            blue.SetActive(false);
        red = GameObject.Find("red");
        if (Progress.red == false)
            red.SetActive(false);
        yellow = GameObject.Find("yellow");
        if (Progress.yellow == false)
            yellow.SetActive(false);
        green = GameObject.Find("green");
        if (Progress.green == false)
            green.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {




    }
}