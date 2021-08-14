using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    private static SpriteRenderer rend;
    static Sprite doorClosed, doorOpen;
    static BoxCollider2D boxCollider;

    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        doorClosed = Resources.Load<Sprite>("academy/door-closed");
        doorOpen = Resources.Load<Sprite>("academy/door-open");
        rend.sprite = doorClosed;

        boxCollider = this.GetComponent<BoxCollider2D>();
    }

    public static void OpenDoor()
    {
        rend.sprite = doorOpen;
        boxCollider.GetComponent<BoxCollider2D>().enabled = false;
    }
}