using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetBlocks : MonoBehaviour
{
    private SpriteRenderer rend;
    private Sprite redTargetBlock, blueTargetBlock, purpleTargetBlock;
    private string sceneName;


    // Start is called before the first frame update
    private void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        sceneName = scene.name;

        rend = GetComponent<SpriteRenderer>();
        redTargetBlock = Resources.Load<Sprite>("cat_target_block");
        blueTargetBlock = Resources.Load<Sprite>("dog_target_block");
        purpleTargetBlock = Resources.Load<Sprite>("owl_target_block");


        if (sceneName == "ArtemisExercise")
        {
            rend.sprite = redTargetBlock;
        }
        if (sceneName == "IrisExercise")
        {
            rend.sprite = blueTargetBlock;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (sceneName == "ArtemisExercise")
        {
            if (TestExerciseNext.catFlag && TestExerciseNext.dogFlag == false)
            {
                rend.sprite = blueTargetBlock;
            }

            if (TestExerciseNext.dogFlag)
            {
                rend.sprite = purpleTargetBlock;
            }
        }
    }
}
