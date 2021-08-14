using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFamilyQuestion : MonoBehaviour
{
    private SpriteRenderer rend;
    private Sprite question1, question2, question3, question4, question5;

    public GameObject a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z;

    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        question1 = Resources.Load<Sprite>("village/my_family-01");
        question2 = Resources.Load<Sprite>("village/my_family-02");
        question3 = Resources.Load<Sprite>("village/my_family-03");
        question4 = Resources.Load<Sprite>("village/my_family-04");
        question5 = Resources.Load<Sprite>("village/my_family-05");
        rend.sprite = question1;

        if (Progress.lettersExerciseComplete == false)
        {
            a = GameObject.Find("a");
            a.SetActive(false);
            b = GameObject.Find("b");
            b.SetActive(false);
            c = GameObject.Find("c");
            c.SetActive(false);
            d = GameObject.Find("d");
            d.SetActive(false);
            e = GameObject.Find("e");
            e.SetActive(false);
            f = GameObject.Find("f");
            f.SetActive(false);
            g = GameObject.Find("g");
            g.SetActive(false);
            h = GameObject.Find("h");
            h.SetActive(false);
            i = GameObject.Find("i");
            i.SetActive(false);
            j = GameObject.Find("j");
            j.SetActive(false);
            k = GameObject.Find("k");
            k.SetActive(false);
            l = GameObject.Find("l");
            l.SetActive(false);
            m = GameObject.Find("m");
            m.SetActive(false);
            n = GameObject.Find("n");
            n.SetActive(false);
            o = GameObject.Find("o");
            o.SetActive(false);
            p = GameObject.Find("p");
            p.SetActive(false);
            q = GameObject.Find("q");
            q.SetActive(false);
            r = GameObject.Find("r");
            r.SetActive(false);
            s = GameObject.Find("s");
            s.SetActive(false);
            t = GameObject.Find("t");
            t.SetActive(false);
            u = GameObject.Find("u");
            u.SetActive(false);
            v = GameObject.Find("v");
            v.SetActive(false);
            w = GameObject.Find("w");
            w.SetActive(false);
            x = GameObject.Find("x");
            x.SetActive(false);
            y = GameObject.Find("y");
            y.SetActive(false);
            z = GameObject.Find("z");
            z.SetActive(false);
        }
    }

    void Update()
    {
        if (MyFamilyNext.questionNumber == 2)
        {
            rend.sprite = question2;
        }

        if (MyFamilyNext.questionNumber == 3)
        {
            rend.sprite = question3;
        }

        if (MyFamilyNext.questionNumber == 4)
        {
            rend.sprite = question4;
        }

        if (MyFamilyNext.questionNumber == 5)
        {
            rend.sprite = question5;
        }
    }
}
