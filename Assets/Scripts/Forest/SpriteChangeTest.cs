using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpriteChangeTest : MonoBehaviour
{
    public static SpriteRenderer rend;

    public static Sprite fairy01, fairy02, fairy03, fairy04;



    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        fairy01 = Resources.Load<Sprite>("fairy01");
        fairy02 = Resources.Load<Sprite>("fairy02");
        fairy03 = Resources.Load<Sprite>("fairy03");
        fairy04 = Resources.Load<Sprite>("fairy04");
        rend.sprite = fairy01;
    }

}
