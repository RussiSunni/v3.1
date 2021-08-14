using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Block : MonoBehaviour
{
    public Vector2 initialPosition, mousePosition;
    public float deltaX, deltaY;
    public static bool locked, pressed, destroyed;

    public Transform[] targetBlock = new Transform[6];
    public Transform targetBlockSingle;


    // doubleclick 
    public float firstClickTime, timeBetweenClicks;
    public bool coroutineAllowed;
    public int clickCounter;

    // rotation
    public Vector3 RotateStep = new Vector3(0, 180, 0);
    public float RotateSpeed = 5f;
    public Quaternion _targetRot = Quaternion.identity;

    public string sceneName;

    public GameObject[] targetBlocks;


    protected virtual void Start()
    {
        initialPosition = transform.position;

        // doubleclick
        firstClickTime = 0f;
        timeBetweenClicks = 0.3f;
        clickCounter = 0;
        coroutineAllowed = true;

        // target blocks
        Scene scene = SceneManager.GetActiveScene();
        sceneName = scene.name;

        if (sceneName == "ArtemisExercise" || sceneName == "SecretaryExercise")
        {
            targetBlock[0] = GameObject.Find("target_block-1").transform;
            targetBlock[1] = GameObject.Find("target_block-2").transform;
            targetBlock[2] = GameObject.Find("target_block-3").transform;
            targetBlock[3] = GameObject.Find("target_block-4").transform;
            targetBlock[4] = GameObject.Find("target_block-5").transform;
        }
        if (sceneName == "HelloExercise" || sceneName == "ArtemisHello")
        {
            targetBlockSingle = GameObject.Find("target_block-1").transform;
        }
        if (sceneName == "MayandEvaExercise")
        {
            targetBlock[0] = GameObject.Find("target_block-1").transform;
            targetBlock[1] = GameObject.Find("target_block-2").transform;
        }
        if (sceneName == "Academy")
        {

        }

        targetBlocks = GameObject.FindGameObjectsWithTag("target");
    }

    protected virtual void OnMouseDown()
    {
        if (!locked)
        {
            deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
            deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
        }
    }

    protected virtual void OnMouseDrag()
    {
        if (!locked)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePosition.x - deltaX, mousePosition.y - deltaY);
            pressed = true;
        }
    }

    protected virtual void OnMouseUp()
    {
        transform.position = new Vector2(initialPosition.x, initialPosition.y);
    }

    // doubleclick
    // protected virtual IEnumerator DoubleClickDetection()
    // {

    // } 

    protected virtual void Update()
    {
        // rotate
        transform.rotation = Quaternion.Lerp(transform.rotation, _targetRot, RotateSpeed * Time.deltaTime);
    }
}

