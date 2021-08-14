using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleQuestion : MonoBehaviour
{
    public int number;
    public string questionName;
    public string answer;
    public Sprite sprite;
    public List<string> answerOptions = new List<string>();
    public List<Sprite> answerOptionsSprites = new List<Sprite>();
    public List<string> tags = new List<string>();
    public int size;
    public bool answered;
    public bool known;
}