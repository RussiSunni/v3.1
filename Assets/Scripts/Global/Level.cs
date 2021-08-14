using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    void Update()
    {
        this.GetComponent<UnityEngine.UI.Text>().text = Progress.level.ToString();
    }
}