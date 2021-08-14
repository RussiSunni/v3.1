using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeIntroScene : MonoBehaviour
{
    private SpriteRenderer rend;
    private Sprite secretary, teacher;

    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        secretary = Resources.Load<Sprite>("secretary");
        teacher = Resources.Load<Sprite>("teacher");
        rend.sprite = secretary;
    }

    private void Update()
    {
        if (IntroNextScene.numberPresses == 1)
        {
            rend.sprite = teacher;
        }
    }
}