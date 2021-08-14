using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionary : MonoBehaviour
{
    public static GameObject a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z;
    public static GameObject bear, monkey, door, hello, may, eva, mayDefinition, evaDefinition;
    void Start()
    {
        // if (Progress.lettersExerciseComplete == false)
        // {
        //     a = GameObject.Find("a");
        //     a.SetActive(false);
        //     b = GameObject.Find("b");
        //     b.SetActive(false);
        //     c = GameObject.Find("c");
        //     c.SetActive(false);
        //     d = GameObject.Find("d");
        //     d.SetActive(false);
        //     e = GameObject.Find("e");
        //     e.SetActive(false);
        //     f = GameObject.Find("f");
        //     f.SetActive(false);
        //     g = GameObject.Find("g");
        //     g.SetActive(false);
        //     h = GameObject.Find("h");
        //     h.SetActive(false);
        //     i = GameObject.Find("i");
        //     i.SetActive(false);
        //     j = GameObject.Find("j");
        //     j.SetActive(false);
        //     k = GameObject.Find("k");
        //     k.SetActive(false);
        //     l = GameObject.Find("l");
        //     l.SetActive(false);
        //     m = GameObject.Find("m");
        //     m.SetActive(false);
        //     n = GameObject.Find("n");
        //     n.SetActive(false);
        //     o = GameObject.Find("o");
        //     o.SetActive(false);
        //     p = GameObject.Find("p");
        //     p.SetActive(false);
        //     q = GameObject.Find("q");
        //     q.SetActive(false);
        //     r = GameObject.Find("r");
        //     r.SetActive(false);
        //     s = GameObject.Find("s");
        //     s.SetActive(false);
        //     t = GameObject.Find("t");
        //     t.SetActive(false);
        //     u = GameObject.Find("u");
        //     u.SetActive(false);
        //     v = GameObject.Find("v");
        //     v.SetActive(false);
        //     w = GameObject.Find("w");
        //     w.SetActive(false);
        //     x = GameObject.Find("x");
        //     x.SetActive(false);
        //     y = GameObject.Find("y");
        //     y.SetActive(false);
        //     z = GameObject.Find("z");
        //     z.SetActive(false);
        // }


        // if (Progress.bear == false)
        // {
        //     bear = GameObject.Find("bear");
        //     bear.SetActive(false);
        // }

        // if (Progress.monkey == false)
        // {
        //     monkey = GameObject.Find("monkey");
        //     monkey.SetActive(false);
        // }

        // if (Progress.door == false)
        // {
        //     door = GameObject.Find("door");
        //     door.SetActive(false);
        // }

        // if (Progress.hello == false)
        // {
        //     hello = GameObject.Find("HELLO");
        //     hello.SetActive(false);
        // }

        if (Progress.dictionaryMay == false)
        {
            may = GameObject.Find("MAY");
            // mayDefinition = GameObject.Find("May definition");
            may.SetActive(false);
            // mayDefinition.SetActive(false);
        }

        if (Progress.dictionaryEva == false)
        {
            eva = GameObject.Find("EVA");
            // evaDefinition = GameObject.Find("Eva definition");
            eva.SetActive(false);
            // evaDefinition.SetActive(false);
        }
    }
}
