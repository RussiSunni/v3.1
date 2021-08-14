using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exp : MonoBehaviour
{
    void Update()
    {
        this.GetComponent<UnityEngine.UI.Text>().text = Progress.exp.ToString();
    }

}