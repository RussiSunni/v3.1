using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBlocks : MonoBehaviour
{
    GameObject a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, CAT, DOG, OWL, BEAR, MONKEY, HELLO, RED, YELLOW, BLUE, GREEN, DOOR, MAY, EVA;
    private bool book;

    void Start()
    {
        book = true;

        CAT = GameObject.Find("CAT");
        DOG = GameObject.Find("DOG");
        OWL = GameObject.Find("OWL");
        BEAR = GameObject.Find("BEAR");
        MONKEY = GameObject.Find("MONKEY");
        HELLO = GameObject.Find("HELLO");
        DOOR = GameObject.Find("DOOR");
        MAY = GameObject.Find("MAY");
        EVA = GameObject.Find("EVA");
        RED = GameObject.Find("RED");
        BLUE = GameObject.Find("BLUE");
        GREEN = GameObject.Find("GREEN");
        YELLOW = GameObject.Find("YELLOW");

        if (!Progress.cat)
            CAT.SetActive(false);

        if (!Progress.dog)
            DOG.SetActive(false);

        if (!Progress.bear)
            BEAR.SetActive(false);

        if (!Progress.monkey)
            MONKEY.SetActive(false);

        if (!Progress.owl)
            OWL.SetActive(false);

        if (!Progress.door)
            DOOR.SetActive(false);

        if (!Progress.red)
            RED.SetActive(false);

        if (!Progress.blue)
            BLUE.SetActive(false);

        if (!Progress.green)
            GREEN.SetActive(false);

        if (!Progress.yellow)
            YELLOW.SetActive(false);

        if (!Progress.hello)
            HELLO.SetActive(false);

        if (!Progress.may)
            MAY.SetActive(false);

        if (!Progress.eva)
            EVA.SetActive(false);



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

    private void OnMouseDown()
    {
        if (book)
        {
            book = false;

            // if (Progress.lettersExerciseComplete)
            // {
            //     if (A.destroyed == false && A.locked == false)
            //     {
            //         a.SetActive(true);
            //     }
            //     if (B.destroyed == false && B.locked == false)
            //     {
            //         b.SetActive(true);
            //     }
            //     if (C.destroyed == false && C.locked == false)
            //     {
            //         c.SetActive(true);
            //     }
            //     if (D.destroyed == false && D.locked == false)
            //     {
            //         d.SetActive(true);
            //     }
            //     if (E.destroyed == false && E.locked == false)
            //     {
            //         e.SetActive(true);
            //     }
            //     if (F.destroyed == false && F.locked == false)
            //     {
            //         f.SetActive(true);
            //     }
            //     if (G.destroyed == false && G.locked == false)
            //     {
            //         g.SetActive(true);
            //     }
            //     if (H.destroyed == false && H.locked == false)
            //     {
            //         h.SetActive(true);
            //     }
            //     if (I.destroyed == false && I.locked == false)
            //     {
            //         i.SetActive(true);
            //     }
            //     if (J.destroyed == false && J.locked == false)
            //     {
            //         j.SetActive(true);
            //     }
            //     if (K.destroyed == false && K.locked == false)
            //     {
            //         k.SetActive(true);
            //     }
            //     if (L.destroyed == false && L.locked == false)
            //     {
            //         l.SetActive(true);
            //     }
            //     if (M.destroyed == false && M.locked == false)
            //     {
            //         m.SetActive(true);
            //     }
            //     if (N.destroyed == false && N.locked == false)
            //     {
            //         n.SetActive(true);
            //     }
            //     if (O.destroyed == false && O.locked == false)
            //     {
            //         o.SetActive(true);
            //     }
            //     if (P.destroyed == false && P.locked == false)
            //     {
            //         p.SetActive(true);
            //     }
            //     if (Q.destroyed == false && Q.locked == false)
            //     {
            //         q.SetActive(true);
            //     }
            //     if (R.destroyed == false && R.locked == false)
            //     {
            //         r.SetActive(true);
            //     }
            //     if (S.destroyed == false && S.locked == false)
            //     {
            //         s.SetActive(true);
            //     }
            //     if (T.destroyed == false && T.locked == false)
            //     {
            //         t.SetActive(true);
            //     }
            //     if (U.destroyed == false && U.locked == false)
            //     {
            //         u.SetActive(true);
            //     }
            //     if (V.destroyed == false && V.locked == false)
            //     {
            //         v.SetActive(true);
            //     }
            //     if (W.destroyed == false && W.locked == false)
            //     {
            //         w.SetActive(true);
            //     }
            //     if (X.destroyed == false && X.locked == false)
            //     {
            //         x.SetActive(true);
            //     }
            //     if (Y.destroyed == false && Y.locked == false)
            //     {
            //         y.SetActive(true);
            //     }
            //     if (Z.destroyed == false && X.locked == false)
            //     {
            //         z.SetActive(true);
            //     }
            // }


            // if (TestExerciseNext.catFlag)
            // {
            //     CAT.SetActive(false);
            // }

            // if (TestExerciseNext.dogFlag)
            // {
            //     DOG.SetActive(false);
            // }

            // if (TestExerciseNext.owlFlag)
            // {
            //     OWL.SetActive(false);
            // }

            // if (TestExerciseNext.bearFlag || Progress.bear)
            // {
            //     BEAR.SetActive(false);
            // }


            MONKEY.SetActive(false);
            DOOR.SetActive(false);
            RED.SetActive(false);
            BLUE.SetActive(false);
            GREEN.SetActive(false);
            YELLOW.SetActive(false);
            HELLO.SetActive(false);
            MAY.SetActive(false);
            EVA.SetActive(false);
        }
        else
        {
            book = true;
            // if (Progress.lettersExerciseComplete)
            // {
            //     if (A.destroyed == false)
            //     {
            //         a.SetActive(false);
            //     }
            //     if (A.destroyed == false)
            //     {
            //         a.SetActive(false);
            //     }
            //     if (B.destroyed == false)
            //     {
            //         b.SetActive(false);
            //     }
            //     if (C.destroyed == false)
            //     {
            //         c.SetActive(false);
            //     }
            //     if (D.destroyed == false)
            //     {
            //         d.SetActive(false);
            //     }
            //     if (E.destroyed == false)
            //     {
            //         e.SetActive(false);
            //     }
            //     if (F.destroyed == false)
            //     {
            //         f.SetActive(false);
            //     }
            //     if (G.destroyed == false)
            //     {
            //         g.SetActive(false);
            //     }
            //     if (H.destroyed == false)
            //     {
            //         h.SetActive(false);
            //     }
            //     if (I.destroyed == false)
            //     {
            //         i.SetActive(false);
            //     }
            //     if (J.destroyed == false)
            //     {
            //         j.SetActive(false);
            //     }
            //     if (K.destroyed == false)
            //     {
            //         k.SetActive(false);
            //     }
            //     if (L.destroyed == false)
            //     {
            //         l.SetActive(false);
            //     }
            //     if (M.destroyed == false)
            //     {
            //         m.SetActive(false);
            //     }
            //     if (N.destroyed == false)
            //     {
            //         n.SetActive(false);
            //     }
            //     if (O.destroyed == false)
            //     {
            //         o.SetActive(false);
            //     }
            //     if (P.destroyed == false)
            //     {
            //         p.SetActive(false);
            //     }
            //     if (Q.destroyed == false)
            //     {
            //         q.SetActive(false);
            //     }
            //     if (R.destroyed == false)
            //     {
            //         r.SetActive(false);
            //     }
            //     if (S.destroyed == false)
            //     {
            //         s.SetActive(false);
            //     }
            //     if (T.destroyed == false)
            //     {
            //         t.SetActive(false);
            //     }
            //     if (U.destroyed == false)
            //     {
            //         u.SetActive(false);
            //     }
            //     if (V.destroyed == false)
            //     {
            //         v.SetActive(false);
            //     }
            //     if (W.destroyed == false)
            //     {
            //         w.SetActive(false);
            //     }
            //     if (X.destroyed == false)
            //     {
            //         x.SetActive(false);
            //     }
            //     if (Y.destroyed == false)
            //     {
            //         y.SetActive(false);
            //     }
            //     if (Z.destroyed == false)
            //     {
            //         z.SetActive(false);
            //     }
            // }

            if (Progress.monkey)
                MONKEY.SetActive(true);

            if (Progress.door)
                DOOR.SetActive(true);

            if (Progress.red)
                RED.SetActive(true);

            if (Progress.blue)
                BLUE.SetActive(true);

            if (Progress.green)
                GREEN.SetActive(true);

            if (Progress.yellow)
                YELLOW.SetActive(true);

            if (Progress.hello)
                HELLO.SetActive(true);

            if (Progress.may)
                MAY.SetActive(true);

            if (Progress.eva)
                EVA.SetActive(true);

        }
    }
}
