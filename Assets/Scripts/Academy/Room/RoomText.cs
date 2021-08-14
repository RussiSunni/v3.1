using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomText : MonoBehaviour
{
    static Text roomText;
    void Start()
    {
        roomText = GetComponent<Text>();
        roomText.text = "Name: " + Progress.nameString;
    }
}
