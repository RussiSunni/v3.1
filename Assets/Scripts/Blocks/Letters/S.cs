using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S : Block
{
    private GameObject fairy;
    Animator fairyAnimator;


    // instantiate copy
    GameObject letter;
    Transform parent;

    protected override void Start()
    {
        base.Start();

        if (sceneName == "ArtemisExercise")
        {
            fairy = GameObject.Find("Fairy");
            fairyAnimator = fairy.GetComponent<Animator>();
        }

        // doubleclick
        firstClickTime = 0f;
        timeBetweenClicks = 0.3f;
        clickCounter = 0;
        coroutineAllowed = true;

        //instantiate copy
        parent = GameObject.Find("ExerciseArea").transform;
        letter = (GameObject)Resources.Load("prefabs/s", typeof(GameObject));
    }

    protected override void OnMouseDown()
    {
        if (sceneName == "ArtemisExercise")
        {
            fairyAnimator.runtimeAnimatorController = null;
        }

        base.OnMouseDown();
    }

    protected override void OnMouseDrag()
    {
        base.OnMouseDrag();

        if (sceneName == "ArtemisExercise")
        {
            SpriteChangeTest.rend.sprite = SpriteChangeTest.fairy01;
        }
    }

    protected override void OnMouseUp()
    {
        pressed = false;
        if (sceneName == "SecretaryExercise")
        {
            transform.position = ReplaceBlocks(transform.position.x, transform.position.y, initialPosition.x, initialPosition.y, -1.87f, -4.379f);
        }
        else if (sceneName == "ArtemisExercise")
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
        else
        {
            transform.position = new Vector2(initialPosition.x, initialPosition.y);
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
    private IEnumerator DoubleClickDetection()
    {
        coroutineAllowed = false;

        while (Time.time < firstClickTime + timeBetweenClicks)
        {
            if (clickCounter == 2)
            {
                SoundManagerScript.playSLetterSound();
                _targetRot *= Quaternion.Euler(RotateStep);
                break;
            }
            yield return new WaitForEndOfFrame();
        }
        clickCounter = 0;
        firstClickTime = 0f;
        coroutineAllowed = true;
    }

    public Vector3 ReplaceBlocks(float transformPositionX, float transformPositionY, float initialX, float initialY, float localPosX, float localPosY)
    {
        if (sceneName == "SecretaryExercise")
        {
            if (Mathf.Abs(transformPositionX - targetBlock[0].position.x) <= 0.5f && Mathf.Abs(transformPositionY - targetBlock[0].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[0].position.x, targetBlock[0].position.y);
                SoundManagerScript.playCorrectSound();
                Progress.nameArray[0] = "t";
                Transform newObject = Instantiate(letter.transform) as Transform;
                newObject.transform.parent = parent.transform;
                newObject.transform.localPosition = new Vector2(localPosX, localPosY);
            }
            else if (Mathf.Abs(transformPositionX - targetBlock[1].position.x) <= 0.5f &&
                Mathf.Abs(transformPositionY - targetBlock[1].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[1].position.x, targetBlock[1].position.y);
                SoundManagerScript.playCorrectSound();
                Progress.nameArray[1] = "t";
                Transform newObject = Instantiate(letter.transform) as Transform;
                newObject.transform.parent = parent.transform;
                newObject.transform.localPosition = new Vector2(localPosX, localPosY);
            }
            else if (Mathf.Abs(transformPositionX - targetBlock[2].position.x) <= 0.5f &&
              Mathf.Abs(transformPositionY - targetBlock[2].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[2].position.x, targetBlock[2].position.y);
                SoundManagerScript.playCorrectSound();
                Progress.nameArray[2] = "t";
                Transform newObject = Instantiate(letter.transform) as Transform;
                newObject.transform.parent = parent.transform;
                newObject.transform.localPosition = new Vector2(localPosX, localPosY);
            }
            else if (Mathf.Abs(transformPositionX - targetBlock[3].position.x) <= 0.5f &&
              Mathf.Abs(transformPositionY - targetBlock[3].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[3].position.x, targetBlock[3].position.y);
                SoundManagerScript.playCorrectSound();
                Progress.nameArray[3] = "t";
                Transform newObject = Instantiate(letter.transform) as Transform;
                newObject.transform.parent = parent.transform;
                newObject.transform.localPosition = new Vector2(localPosX, localPosY);
            }
            else if (Mathf.Abs(transformPositionX - targetBlock[4].position.x) <= 0.5f &&
            Mathf.Abs(transformPositionY - targetBlock[4].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[4].position.x, targetBlock[4].position.y);
                SoundManagerScript.playCorrectSound();
                Progress.nameArray[4] = "t";
                Transform newObject = Instantiate(letter.transform) as Transform;
                newObject.transform.parent = parent.transform;
                newObject.transform.localPosition = new Vector2(localPosX, localPosY);
            }
            else
            {
                transform.position = new Vector2(initialX, initialY);
            }
        }
        return transform.position;
    }
}
