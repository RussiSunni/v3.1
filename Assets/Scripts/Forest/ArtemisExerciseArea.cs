using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtemisExerciseArea : MonoBehaviour
{
    private SpriteRenderer rend;
    private Sprite bg1, bg2, bg3, bg4, bg5;
    public GameObject tb1, tb2, tb3, tb4, cat, dog;
    Vector3 tb1Position, tb2Position, tb3Position, tb4Position;

    //Vector3 newCatPosition;

    public Camera ArtemisCamera, ExerciseCamera;
    private static Camera artCam, exerCam;
    public static bool artemis;
    private bool catEnabled = true, dogEnabled = true;


    // Start is called before the first frame update
    private void Start()
    {
        // camera
        artCam = ArtemisCamera;
        exerCam = ExerciseCamera;
        ArtemisCamera.gameObject.SetActive(true);
        ExerciseCamera.gameObject.SetActive(false);


        rend = GetComponent<SpriteRenderer>();
        bg1 = Resources.Load<Sprite>("cat_bg");
        bg2 = Resources.Load<Sprite>("dog_bg");
        bg3 = Resources.Load<Sprite>("owl_bg");
        bg4 = Resources.Load<Sprite>("bear_bg");
        bg5 = Resources.Load<Sprite>("wolf_bg");
        rend.sprite = bg1;


        cat = GameObject.Find("CAT");
        cat.SetActive(false);
        dog = GameObject.Find("DOG");
        dog.SetActive(false);


        GameObject.Find("OWL").SetActive(false);

        if (Progress.bear == false)
            GameObject.Find("BEAR").SetActive(false);


        GameObject.Find("WOLF").SetActive(false);

        GameObject.Find("Fairy animation").SetActive(false);


        // set target block positions
        tb1Position.x = -5.732f;
        tb1Position.y = -2.503f;
        tb1 = GameObject.Find("target_block-1");
        tb1.transform.position = tb1Position;

        tb2Position.x = -3.873f;
        tb2Position.y = -2.503f;
        tb2 = GameObject.Find("target_block-2");
        tb2.transform.position = tb2Position;

        tb3Position.x = -2.014f;
        tb3Position.y = -2.503f;
        tb3 = GameObject.Find("target_block-3");
        tb3.transform.position = tb3Position;

        tb4 = GameObject.Find("target_block-4");
    }

    // Update is called once per frame
    void Update()
    {
        if (TestExerciseNext.catFlag)
        {
            rend.sprite = bg2;
        }

        if (TestExerciseNext.dogFlag)
        {
            rend.sprite = bg3;
        }

        if (TestExerciseNext.owlFlag)
        {
            rend.sprite = bg4;

            // set target block positions
            tb1Position.x = -6.3f;
            tb1Position.y = -2.503f;
            tb1.transform.position = tb1Position;

            tb2Position.x = -4.7f;
            tb2Position.y = -2.503f;
            tb2.transform.position = tb2Position;

            tb3Position.x = -3.1f;
            tb3Position.y = -2.503f;
            tb3.transform.position = tb3Position;

            tb4Position.x = -1.5f;
            tb4Position.y = -2.503f;
            tb4.transform.position = tb4Position;
        }

        if (TestExerciseNext.bearFlag)
        {
            rend.sprite = bg5;

            // set target block positions
            tb1Position.x = -6.3f;
            tb1Position.y = -2.503f;
            tb1.transform.position = tb1Position;

            tb2Position.x = -4.7f;
            tb2Position.y = -2.503f;
            tb2.transform.position = tb2Position;

            tb3Position.x = -3.1f;
            tb3Position.y = -2.503f;
            tb3.transform.position = tb3Position;

            tb4Position.x = -1.5f;
            tb4Position.y = -2.503f;
            tb4.transform.position = tb4Position;
        }

        if (C.locked && A.locked && T.locked && catEnabled)
        {

            cat.SetActive(true);
            catEnabled = false;
        }

        if (D.locked && O.locked && G.locked)
        {
            if (dogEnabled)
            {
                dog.SetActive(true);
                dogEnabled = false;
            }
        }
    }

    public static void SwitchCamera()
    {
        if (artemis == false)
        {
            artCam.gameObject.SetActive(false);
            exerCam.gameObject.SetActive(true);
        }

        if (artemis)
        {
            artCam.gameObject.SetActive(true);
            artemis = false;
            NewLetter.soundPlaying = false;
        }
    }
}