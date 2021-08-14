using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpellBookUI : MonoBehaviour
{
    public static GameObject door, hello, hi, goodbye, may, eva, sue, read, bear, monkey, cat, dog, blue, red, yellow, green, yes, no;
    void Start()
    {
        if (Progress.bear == false)
        {
            bear = GameObject.Find("BEAR_UI");
            bear.SetActive(false);
        }
        if (Progress.monkey == false)
        {
            monkey = GameObject.Find("MONKEY_UI");
            monkey.SetActive(false);
        }
        if (Progress.cat == false)
        {
            cat = GameObject.Find("CAT_UI");
            cat.SetActive(false);
        }
        if (Progress.dog == false)
        {
            dog = GameObject.Find("DOG_UI");
            dog.SetActive(false);
        }
        if (Progress.door == false)
        {
            door = GameObject.Find("DOOR_UI");
            door.SetActive(false);
        }
        if (Progress.hello == false)
        {
            hello = GameObject.Find("HELLO_UI");
            hello.SetActive(false);
        }
        if (Progress.hi == false)
        {
            hi = GameObject.Find("HI_UI");
            hi.SetActive(false);
        }
        {
            goodbye = GameObject.Find("GOODBYE_UI");
            goodbye.SetActive(false);
        }
        if (Progress.may == false)
        {
            may = GameObject.Find("MAY_UI");
            may.SetActive(false);
        }
        if (Progress.eva == false)
        {
            eva = GameObject.Find("EVA_UI");
            eva.SetActive(false);
        }
        if (Progress.sue == false)
        {
            sue = GameObject.Find("SUE_UI");
            sue.SetActive(false);
        }
        if (Progress.red == false)
        {
            red = GameObject.Find("RED_UI");
            red.SetActive(false);
        }
        if (Progress.blue == false)
        {
            blue = GameObject.Find("BLUE_UI");
            blue.SetActive(false);
        }
        if (Progress.yellow == false)
        {
            yellow = GameObject.Find("YELLOW_UI");
            yellow.SetActive(false);
        }
        if (Progress.green == false)
        {
            green = GameObject.Find("GREEN_UI");
            green.SetActive(false);
        }
        if (Progress.read == false)
        {
            read = GameObject.Find("READ_UI");
            read.SetActive(false);
        }
        if (Progress.yes == false)
        {
            yes = GameObject.Find("YES_UI");
            yes.SetActive(false);
        }
        if (Progress.no == false)
        {
            no = GameObject.Find("NO_UI");
            no.SetActive(false);
        }
    }

    public static void Door()
    {
        door.SetActive(true);
    }
    public static void Hello()
    {
        hello.SetActive(true);
    }
    public static void May()
    {
        may.SetActive(true);
    }
    public static void Eva()
    {
        eva.SetActive(true);
    }
    public static void Sue()
    {
        sue.SetActive(true);
    }
    public static void Hi()
    {
        hi.SetActive(true);
    }
    public static void Goodbye()
    {
        goodbye.SetActive(true);
    }
    public static void Read()
    {
        read.SetActive(true);
    }
    public static void Yes()
    {
        yes.SetActive(true);
    }
    public static void No()
    {
        no.SetActive(true);
    }
}
