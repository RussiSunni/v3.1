using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W : Block
{
    public static bool reset;
    private GameObject fairy;
    Animator fairyAnimator;

    // instantiate copy
    GameObject letterW;
    Transform parent;

    protected override void Start()
    {
        base.Start();

        if (sceneName == "ArtemisExercise")
        {
            fairy = GameObject.Find("Fairy");
            fairyAnimator = fairy.GetComponent<Animator>();
        }

        //instantiate copy
        parent = GameObject.Find("ExerciseArea").transform;
        letterW = (GameObject)Resources.Load("prefabs/w", typeof(GameObject));
    }

    protected override void OnMouseDrag()
    {
        base.OnMouseDrag();

        if (sceneName == "ArtemisExercise")
        {
            fairyAnimator.runtimeAnimatorController = null;

            if (TestExerciseNext.dogFlag && TestExerciseNext.owlFlag == false || TestExerciseNext.bearFlag && TestExerciseNext.wolfFlag == false)
            {
                SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy02;
            }
            else
            {
                SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy01;
            }
        }
    }

    protected override void OnMouseUp()
    {
        pressed = false;
        if (sceneName == "SecretaryExercise")
        {
            if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f && Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[0].position.x, targetBlock[0].position.y);
                SoundManagerScript.playCorrectSound();
                Progress.nameArray[0] = "w";
                Transform newW = Instantiate(letterW.transform) as Transform;
                newW.transform.parent = parent.transform;
                newW.transform.localPosition = new Vector2(-4.368f, -1.874f);
            }
            else if (Mathf.Abs(transform.position.x - targetBlock[1].position.x) <= 0.5f &&
                Mathf.Abs(transform.position.y - targetBlock[1].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[1].position.x, targetBlock[1].position.y);
                SoundManagerScript.playCorrectSound();
                Progress.nameArray[1] = "w";
                Transform newW = Instantiate(letterW.transform) as Transform;
                newW.transform.parent = parent.transform;
                newW.transform.localPosition = new Vector2(-4.368f, -1.874f);
            }
            else if (Mathf.Abs(transform.position.x - targetBlock[2].position.x) <= 0.5f &&
              Mathf.Abs(transform.position.y - targetBlock[2].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[2].position.x, targetBlock[2].position.y);
                SoundManagerScript.playCorrectSound();
                Progress.nameArray[2] = "w";
                Transform newW = Instantiate(letterW.transform) as Transform;
                newW.transform.parent = parent.transform;
                newW.transform.localPosition = new Vector2(-4.368f, -1.874f);
            }
            else if (Mathf.Abs(transform.position.x - targetBlock[3].position.x) <= 0.5f &&
              Mathf.Abs(transform.position.y - targetBlock[3].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[3].position.x, targetBlock[3].position.y);
                SoundManagerScript.playCorrectSound();
                Progress.nameArray[3] = "w";
                Transform newW = Instantiate(letterW.transform) as Transform;
                newW.transform.parent = parent.transform;
                newW.transform.localPosition = new Vector2(-4.368f, -1.874f);
            }
            else if (Mathf.Abs(transform.position.x - targetBlock[4].position.x) <= 0.5f &&
            Mathf.Abs(transform.position.y - targetBlock[4].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[4].position.x, targetBlock[4].position.y);
                SoundManagerScript.playCorrectSound();
                Progress.nameArray[4] = "w";
                Transform newW = Instantiate(letterW.transform) as Transform;
                newW.transform.parent = parent.transform;
                newW.transform.localPosition = new Vector2(-4.368f, -1.874f);
            }
            else
            {
                transform.position = new Vector2(initialPosition.x, initialPosition.y);
            }
        }
        else if (sceneName == "ArtemisExercise")
        {
            // OWL
            if (TestExerciseNext.dogFlag && TestExerciseNext.owlFlag == false)
            {
                if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f &&
                         Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f ||
                         Mathf.Abs(transform.position.x - targetBlock[2].position.x) <= 0.5f &&
                         Mathf.Abs(transform.position.y - targetBlock[2].position.y) <= 0.5f)
                {
                    this.gameObject.SetActive(false);
                    destroyed = true;
                    SoundManagerScript.playErrorSound();
                    fairyAnimator.runtimeAnimatorController = Resources.Load("fairy disappointed 1") as RuntimeAnimatorController;
                }
                else if (Mathf.Abs(transform.position.x - targetBlock[1].position.x) <= 0.5f &&
                     Mathf.Abs(transform.position.y - targetBlock[1].position.y) <= 0.5f)
                {
                    transform.position = new Vector2(targetBlock[1].position.x, targetBlock[1].position.y);
                    locked = true;
                    SoundManagerScript.playCorrectSound();
                    SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy03;
                }
                else
                {
                    transform.position = new Vector2(initialPosition.x, initialPosition.y);
                    SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy01;
                }
            }
            // WOLF
            else if (TestExerciseNext.dogFlag && TestExerciseNext.wolfFlag == false)
            {
                if (Mathf.Abs(transform.position.x - targetBlock[1].position.x) <= 0.5f &&
                         Mathf.Abs(transform.position.y - targetBlock[1].position.y) <= 0.5f ||
                         Mathf.Abs(transform.position.x - targetBlock[2].position.x) <= 0.5f &&
                         Mathf.Abs(transform.position.y - targetBlock[2].position.y) <= 0.5f ||
                           Mathf.Abs(transform.position.x - targetBlock[3].position.x) <= 0.5f &&
                         Mathf.Abs(transform.position.y - targetBlock[3].position.y) <= 0.5f)
                {
                    this.gameObject.SetActive(false);
                    destroyed = true;
                    SoundManagerScript.playErrorSound();
                    fairyAnimator.runtimeAnimatorController = Resources.Load("fairy disappointed 1") as RuntimeAnimatorController;
                }
                else if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f &&
                     Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f)
                {
                    transform.position = new Vector2(targetBlock[0].position.x, targetBlock[0].position.y);
                    locked = true;
                    SoundManagerScript.playCorrectSound();
                    SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy03;
                }
                else
                {
                    transform.position = new Vector2(initialPosition.x, initialPosition.y);
                    SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy01;
                }
            }
            else
            {
                if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f &&
                                              Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f ||
                                              Mathf.Abs(transform.position.x - targetBlock[1].position.x) <= 0.5f &&
                                              Mathf.Abs(transform.position.y - targetBlock[1].position.y) <= 0.5f ||
                                              Mathf.Abs(transform.position.x - targetBlock[2].position.x) <= 0.5f &&
                                              Mathf.Abs(transform.position.y - targetBlock[2].position.y) <= 0.5f ||
                                               Mathf.Abs(transform.position.x - targetBlock[3].position.x) <= 0.5f &&
                                              Mathf.Abs(transform.position.y - targetBlock[3].position.y) <= 0.5f)
                {
                    this.gameObject.SetActive(false);
                    destroyed = true;
                    SoundManagerScript.playErrorSound();
                    fairyAnimator.runtimeAnimatorController = Resources.Load("fairy disappointed 1") as RuntimeAnimatorController;
                }
                else
                {
                    transform.position = new Vector2(initialPosition.x, initialPosition.y);
                    SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy01;
                }
            }
        }
        // doubleclick
        if (Input.GetMouseButtonUp(0))
            clickCounter += 1;

        if (clickCounter == 1 && coroutineAllowed)
        {
            firstClickTime = Time.time;
            StartCoroutine(DoubleClickDetection());
        }
    }

    // doubleclick
    protected IEnumerator DoubleClickDetection()
    {
        coroutineAllowed = false;

        while (Time.time < firstClickTime + timeBetweenClicks)
        {
            if (clickCounter == 2)
            {
                SoundManagerScript.playWLetterSound();
                _targetRot *= Quaternion.Euler(RotateStep);
                break;
            }
            yield return new WaitForEndOfFrame();
        }
        clickCounter = 0;
        firstClickTime = 0f;
        coroutineAllowed = true;
    }
    protected override void Update()
    {
        if (reset)
        {
            transform.position = new Vector2(initialPosition.x, initialPosition.y);
            reset = false;
        }
        base.Update();
    }
}
