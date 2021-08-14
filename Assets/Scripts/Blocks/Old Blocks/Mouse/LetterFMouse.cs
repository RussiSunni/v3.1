using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LetterFMouse : MonoBehaviour
{
    Transform[] cat = new Transform[3];

    Transform[] dog = new Transform[3];

    private Vector2 initialPosition;

    private Vector2 mousePosition;

    private float deltaX, deltaY;

    public static bool locked;

    private string sceneName;



    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;


        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "CatExercise")
        {
            cat[0] = GameObject.Find("cat_target_block-a").transform;
            cat[1] = GameObject.Find("cat_target_block-c").transform;
            cat[2] = GameObject.Find("cat_target_block-t").transform;
        }
        if (sceneName == "DogExercise")
        {
            dog[0] = GameObject.Find("dog_target_block-d").transform;
            dog[1] = GameObject.Find("dog_target_block-g").transform;
            dog[2] = GameObject.Find("dog_target_block-o").transform;
        }

    }

    private void OnMouseDown()
    {
        if (!locked)
        {
            deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
            deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
        }

    }

    private void OnMouseDrag()
    {
        if (!locked)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePosition.x - deltaX, mousePosition.y - deltaY);
        }
    }

    private void OnMouseUp()
    {
        // if put in incorrect posistion - CAT
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        // if put in incorrect posistion - CAT
        if (sceneName == "CatExercise")
        {

            if (Mathf.Abs(transform.position.x - cat[0].position.x) <= 0.5f &&
                     Mathf.Abs(transform.position.y - cat[0].position.y) <= 0.5f ||
                     Mathf.Abs(transform.position.x - cat[1].position.x) <= 0.5f &&
                     Mathf.Abs(transform.position.y - cat[1].position.y) <= 0.5f ||
                     Mathf.Abs(transform.position.x - cat[2].position.x) <= 0.5f &&
                     Mathf.Abs(transform.position.y - cat[2].position.y) <= 0.5f)
            {
                Destroy(this.gameObject);
                SoundManagerScript.playErrorSound();
            }
            else
            {
                transform.position = new Vector2(initialPosition.x, initialPosition.y);
            }
        }
        // DOG 
        if (sceneName == "DogExercise")
        {
            // if put in incorrect posistion
            if (Mathf.Abs(transform.position.x - dog[0].position.x) <= 0.5f &&
                     Mathf.Abs(transform.position.y - dog[0].position.y) <= 0.5f ||
                     Mathf.Abs(transform.position.x - dog[1].position.x) <= 0.5f &&
                     Mathf.Abs(transform.position.y - dog[1].position.y) <= 0.5f ||
                     Mathf.Abs(transform.position.x - dog[2].position.x) <= 0.5f &&
                     Mathf.Abs(transform.position.y - dog[2].position.y) <= 0.5f)
            {
                Destroy(this.gameObject);
                SoundManagerScript.playErrorSound();
            }
            else
            {
                transform.position = new Vector2(initialPosition.x, initialPosition.y);
            }
        }
        else
        {
            transform.position = new Vector2(initialPosition.x, initialPosition.y);
        }
    }

}
