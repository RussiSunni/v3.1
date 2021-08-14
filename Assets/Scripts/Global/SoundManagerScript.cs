using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip errorSound, correctSound, spell01Sound, newWordSound, WHAT_IS_YOUR_NAME_Sound, CATWordSound, DOGWordSound, OWLWordSound, BEARWordSound, WOLFWordSound, MONKEYWordSound, DOORWordSound, HELLOWordSound, HIWordSound, GOODBYEWordSound, MAYWordSound, EVAWordSound, SUEWordSound, READWordSound, ALetterSound, BLetterSound, CLetterSound, DLetterSound, ELetterSound, FLetterSound, GLetterSound, HLetterSound, ILetterSound, JLetterSound, KLetterSound, LLetterSound, MLetterSound, NLetterSound, OLetterSound, PLetterSound, QLetterSound, RLetterSound, SLetterSound, TLetterSound, ULetterSound, VLetterSound, WLetterSound, XLetterSound, YLetterSound, ZLetterSound;
    static AudioSource audioSrc;


    // Start is called before the first frame update
    void Start()
    {
        errorSound = Resources.Load<AudioClip>("sounds/pop");
        correctSound = Resources.Load<AudioClip>("sounds/success");
        spell01Sound = Resources.Load<AudioClip>("sounds/spell01");
        WHAT_IS_YOUR_NAME_Sound = Resources.Load<AudioClip>("sounds/WHAT_IS_YOUR_NAME_Sound");
        CATWordSound = Resources.Load<AudioClip>("sounds/CATSound");
        DOGWordSound = Resources.Load<AudioClip>("sounds/DOGSound");
        OWLWordSound = Resources.Load<AudioClip>("sounds/OWLSound");
        BEARWordSound = Resources.Load<AudioClip>("sounds/BEARSound");
        WOLFWordSound = Resources.Load<AudioClip>("sounds/WOLFSound");
        MONKEYWordSound = Resources.Load<AudioClip>("sounds/MONKEYSound");
        DOORWordSound = Resources.Load<AudioClip>("sounds/DOORSound");
        HELLOWordSound = Resources.Load<AudioClip>("sounds/HELLOSound");
        MAYWordSound = Resources.Load<AudioClip>("sounds/MAYSound");
        EVAWordSound = Resources.Load<AudioClip>("sounds/EVASound");
        SUEWordSound = Resources.Load<AudioClip>("sounds/SUESound");
        READWordSound = Resources.Load<AudioClip>("sounds/READSound");
        HIWordSound = Resources.Load<AudioClip>("sounds/HISound");
        GOODBYEWordSound = Resources.Load<AudioClip>("sounds/GOODBYESound");
        ALetterSound = Resources.Load<AudioClip>("sounds/ASound");
        BLetterSound = Resources.Load<AudioClip>("sounds/BSound");
        CLetterSound = Resources.Load<AudioClip>("sounds/CSound");
        DLetterSound = Resources.Load<AudioClip>("sounds/DSound");
        ELetterSound = Resources.Load<AudioClip>("sounds/ESound");
        FLetterSound = Resources.Load<AudioClip>("sounds/FSound");
        GLetterSound = Resources.Load<AudioClip>("sounds/GSound");
        HLetterSound = Resources.Load<AudioClip>("sounds/HSound");
        ILetterSound = Resources.Load<AudioClip>("sounds/ISound");
        JLetterSound = Resources.Load<AudioClip>("sounds/JSound");
        KLetterSound = Resources.Load<AudioClip>("sounds/KSound");
        LLetterSound = Resources.Load<AudioClip>("sounds/LSound");
        MLetterSound = Resources.Load<AudioClip>("sounds/MSound");
        NLetterSound = Resources.Load<AudioClip>("sounds/NSound");
        OLetterSound = Resources.Load<AudioClip>("sounds/OSound");
        PLetterSound = Resources.Load<AudioClip>("sounds/PSound");
        QLetterSound = Resources.Load<AudioClip>("sounds/QSound");
        RLetterSound = Resources.Load<AudioClip>("sounds/RSound");
        SLetterSound = Resources.Load<AudioClip>("sounds/SSound");
        TLetterSound = Resources.Load<AudioClip>("sounds/TSound");
        ULetterSound = Resources.Load<AudioClip>("sounds/USound");
        VLetterSound = Resources.Load<AudioClip>("sounds/VSound");
        WLetterSound = Resources.Load<AudioClip>("sounds/WSound");
        XLetterSound = Resources.Load<AudioClip>("sounds/XSound");
        YLetterSound = Resources.Load<AudioClip>("sounds/YSound");
        ZLetterSound = Resources.Load<AudioClip>("sounds/ZSound");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame

    public static void playCorrectSound()
    {
        audioSrc.PlayOneShot(correctSound);
    }
    public static void playSpell01Sound()
    {
        audioSrc.PlayOneShot(spell01Sound);
    }
    public static void playErrorSound()
    {
        audioSrc.PlayOneShot(errorSound);
    }

    public static void playNewWordSound()
    {
        audioSrc.PlayOneShot(newWordSound);
    }


    // words
    public static void playCATWordSound()
    {
        audioSrc.PlayOneShot(CATWordSound);
    }

    public static void playDOGWordSound()
    {
        audioSrc.PlayOneShot(DOGWordSound);
    }

    public static void playOWLWordSound()
    {
        audioSrc.PlayOneShot(OWLWordSound);
    }

    public static void playBEARWordSound()
    {
        audioSrc.PlayOneShot(BEARWordSound);
    }

    public static void playWOLFWordSound()
    {
        audioSrc.PlayOneShot(WOLFWordSound);
    }
    public static void playMONKEYWordSound()
    {
        audioSrc.PlayOneShot(MONKEYWordSound);
    }

    public static void playDOORWordSound()
    {
        audioSrc.PlayOneShot(DOORWordSound);
    }

    public static void playHELLOWordSound()
    {
        audioSrc.PlayOneShot(HELLOWordSound);
    }

    public static void playHIWordSound()
    {
        audioSrc.PlayOneShot(HIWordSound);
    }
    public static void playGOODBYEWordSound()
    {
        audioSrc.PlayOneShot(GOODBYEWordSound);
    }

    public static void playMAYWordSound()
    {
        audioSrc.PlayOneShot(MAYWordSound);
    }

    public static void playEVAWordSound()
    {
        audioSrc.PlayOneShot(EVAWordSound);
    }

    public static void playSUEWordSound()
    {
        audioSrc.PlayOneShot(SUEWordSound);
    }

    public static void playREADWordSound()
    {
        audioSrc.PlayOneShot(READWordSound);
    }

    public static void playWHAT_IS_YOUR_NAME_Sound()
    {
        audioSrc.PlayOneShot(WHAT_IS_YOUR_NAME_Sound);
    }



    // letters
    public static void playALetterSound()
    {
        audioSrc.PlayOneShot(ALetterSound);
    }
    public static void playBLetterSound()
    {
        audioSrc.PlayOneShot(BLetterSound);
    }
    public static void playCLetterSound()
    {
        audioSrc.PlayOneShot(CLetterSound);
    }
    public static void playDLetterSound()
    {
        audioSrc.PlayOneShot(DLetterSound);
    }
    public static void playELetterSound()
    {
        audioSrc.PlayOneShot(ELetterSound);
    }
    public static void playFLetterSound()
    {
        audioSrc.PlayOneShot(FLetterSound);
    }
    public static void playGLetterSound()
    {
        audioSrc.PlayOneShot(GLetterSound);
    }
    public static void playHLetterSound()
    {
        audioSrc.PlayOneShot(HLetterSound);
    }

    public static void playILetterSound()
    {
        audioSrc.PlayOneShot(ILetterSound);
    }
    public static void playJLetterSound()
    {
        audioSrc.PlayOneShot(JLetterSound);
    }
    public static void playKLetterSound()
    {
        audioSrc.PlayOneShot(KLetterSound);
    }
    public static void playLLetterSound()
    {
        audioSrc.PlayOneShot(LLetterSound);
    }
    public static void playMLetterSound()
    {
        audioSrc.PlayOneShot(MLetterSound);
    }
    public static void playNLetterSound()
    {
        audioSrc.PlayOneShot(NLetterSound);
    }
    public static void playOLetterSound()
    {
        audioSrc.PlayOneShot(OLetterSound);
    }
    public static void playPLetterSound()
    {
        audioSrc.PlayOneShot(PLetterSound);
    }
    public static void playQLetterSound()
    {
        audioSrc.PlayOneShot(QLetterSound);
    }
    public static void playRLetterSound()
    {
        audioSrc.PlayOneShot(RLetterSound);
    }
    public static void playSLetterSound()
    {
        audioSrc.PlayOneShot(SLetterSound);
    }

    public static void playTLetterSound()
    {
        audioSrc.PlayOneShot(TLetterSound);
    }
    public static void playULetterSound()
    {
        audioSrc.PlayOneShot(ULetterSound);
    }
    public static void playVLetterSound()
    {
        audioSrc.PlayOneShot(VLetterSound);
    }
    public static void playWLetterSound()
    {
        audioSrc.PlayOneShot(WLetterSound);
    }

    public static void playXLetterSound()
    {
        audioSrc.PlayOneShot(XLetterSound);
    }
    public static void playYLetterSound()
    {
        audioSrc.PlayOneShot(YLetterSound);
    }
    public static void playZLetterSound()
    {
        audioSrc.PlayOneShot(ZLetterSound);
    }

}
