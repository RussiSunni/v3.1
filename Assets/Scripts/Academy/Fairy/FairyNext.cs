using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FairyNext : MonoBehaviour
{
    public static int questionNumber = 1;
    public GameObject a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, nextButton;
    void Start()
    {
        nextButton = GameObject.Find("NextButton");

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
    public void ChangeQuestion()
    {
        questionNumber++;

        if (questionNumber == 2)
        {
            a.SetActive(true);
            SoundManagerScript.playALetterSound();
        }
        if (questionNumber == 3)
        {
            b.SetActive(true);
            SoundManagerScript.playBLetterSound();
        }
        if (questionNumber == 4)
        {
            c.SetActive(true);
            SoundManagerScript.playCLetterSound();
        }
        if (questionNumber == 5)
        {
            d.SetActive(true);
            SoundManagerScript.playDLetterSound();
        }
        if (questionNumber == 6)
        {
            e.SetActive(true);
            SoundManagerScript.playELetterSound();
        }
        if (questionNumber == 7)
        {
            f.SetActive(true);
            SoundManagerScript.playFLetterSound();
        }
        if (questionNumber == 8)
        {
            g.SetActive(true);
            SoundManagerScript.playGLetterSound();
        }
        if (questionNumber == 9)
        {
            h.SetActive(true);
            SoundManagerScript.playHLetterSound();
        }
        if (questionNumber == 10)
        {
            i.SetActive(true);
            SoundManagerScript.playILetterSound();
        }
        if (questionNumber == 11)
        {
            j.SetActive(true);
            SoundManagerScript.playJLetterSound();
        }
        if (questionNumber == 12)
        {
            k.SetActive(true);
            SoundManagerScript.playKLetterSound();
        }
        if (questionNumber == 13)
        {
            l.SetActive(true);
            SoundManagerScript.playLLetterSound();
        }
        if (questionNumber == 14)
        {
            m.SetActive(true);
            SoundManagerScript.playMLetterSound();
        }
        if (questionNumber == 15)
        {
            n.SetActive(true);
            SoundManagerScript.playNLetterSound();
        }
        if (questionNumber == 16)
        {
            o.SetActive(true);
            SoundManagerScript.playOLetterSound();
        }
        if (questionNumber == 17)
        {
            p.SetActive(true);
            SoundManagerScript.playPLetterSound();
        }
        if (questionNumber == 17)
        {
            q.SetActive(true);
            SoundManagerScript.playQLetterSound();
        }
        if (questionNumber == 18)
        {
            r.SetActive(true);
            SoundManagerScript.playRLetterSound();
        }
        if (questionNumber == 19)
        {
            s.SetActive(true);
            SoundManagerScript.playSLetterSound();
        }
        if (questionNumber == 20)
        {
            t.SetActive(true);
            SoundManagerScript.playTLetterSound();
        }
        if (questionNumber == 21)
        {
            u.SetActive(true);
            SoundManagerScript.playULetterSound();
        }
        if (questionNumber == 22)
        {
            v.SetActive(true);
            SoundManagerScript.playVLetterSound();
        }
        if (questionNumber == 23)
        {
            w.SetActive(true);
            SoundManagerScript.playWLetterSound();
        }
        if (questionNumber == 24)
        {
            x.SetActive(true);
            SoundManagerScript.playXLetterSound();
        }
        if (questionNumber == 25)
        {
            y.SetActive(true);
            SoundManagerScript.playYLetterSound();
        }
        if (questionNumber == 26)
        {
            z.SetActive(true);
            SoundManagerScript.playZLetterSound();
        }
        if (questionNumber == 27)
        {
            nextButton.SetActive(false);
        }
    }
}
