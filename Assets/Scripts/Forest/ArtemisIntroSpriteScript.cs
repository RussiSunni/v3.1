using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtemisIntroSpriteScript : MonoBehaviour
{
    public static SpriteRenderer rend;

    public static Sprite artemis;

    public static bool secondClick;

    void Start()
    {

        secondClick = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (secondClick)
        {
            rend = GetComponent<SpriteRenderer>();
            artemis = Resources.Load<Sprite>("artemis");
            rend.sprite = artemis;
        }
    }
}
