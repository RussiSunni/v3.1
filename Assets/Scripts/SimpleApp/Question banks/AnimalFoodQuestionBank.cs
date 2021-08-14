using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class AnimalFoodQuestionBank : SimpleQuestion
{
    public static List<SimpleQuestion> questions = new List<SimpleQuestion>();
    public static SimpleQuestion animalFood001 = new SimpleQuestion();
    public static SimpleQuestion animalFood002 = new SimpleQuestion();
    public static SimpleQuestion animalFood003 = new SimpleQuestion();
    public static SimpleQuestion animalFood004 = new SimpleQuestion();
    public static SimpleQuestion animalFood005 = new SimpleQuestion();
    public static SimpleQuestion animalFood006 = new SimpleQuestion();
    private Sprite dogSprite,
                    horseSprite,
                    catSprite,
                    rabbitSprite;

    void Start()
    {
        // sprites
        dogSprite = Resources.Load<Sprite>("SimpleApp/Questions/Dog");
        horseSprite = Resources.Load<Sprite>("SimpleApp/Questions/Horse");
        catSprite = Resources.Load<Sprite>("SimpleApp/Questions/Cat");
        rabbitSprite = Resources.Load<Sprite>("SimpleApp/Questions/Rabbit");

        animalFood001 = new SimpleQuestion()
        {
            number = 1,
            questionName = "carrots",
            answer = "horse",
            answerOptionsSprites = new List<Sprite>()
            {
                dogSprite,
                horseSprite,
                catSprite,
                rabbitSprite
            },
            tags = new List<string>()
        {
            "animals", "food"
        },
            size = 1
        };

        animalFood002 = new SimpleQuestion()
        {
            number = 2,
            questionName = "meat",
            answer = "tiger",
            answerOptions = new List<string>()
        {
            "frog",
            "rabbit",
            "tiger",
            "lion"
        },
            tags = new List<string>()
        {
            "animals", "food"
        },
            size = 1
        };

        animalFood003 = new SimpleQuestion()
        {
            number = 3,
            questionName = "cheese",
            answer = "mouse",
            answerOptions = new List<string>()
        {
            "mouse",
            "dolphin",
            "cat",
            "parrot"
        },
            tags = new List<string>()
        {
            "animals", "food"
        },
            size = 1
        };

        animalFood004 = new SimpleQuestion()
        {
            number = 4,
            questionName = "grass",
            answer = "cow",
            answerOptions = new List<string>()
        {
            "zebra",
            "pidgeon",
            "cow",
            "dog"
        },
            tags = new List<string>()
        {
            "animals", "food"
        },
            size = 1
        };


        animalFood005 = new SimpleQuestion()
        {
            number = 5,
            questionName = "banana",
            answer = "monkey",
            answerOptions = new List<string>()
        {
            "elephant",
            "ostrich",
            "mouse",
            "monkey"
        },
            tags = new List<string>()
        {
            "animals", "food"
        },
            size = 1
        };

        animalFood006 = new SimpleQuestion()
        {
            number = 6,
            questionName = "bone",
            answer = "dog",
            answerOptions = new List<string>()
        {
            "lion",
            "dog",
            "mouse",
            "monkey"
        },
            tags = new List<string>()
        {
            "animals", "food"
        },
            size = 1
        };
    }
    public static void LoadQuestionList()
    {
        // if (GameControl.animalFood001known == false)
        questions.Add(animalFood001);
        // questions.Add(animalFood002);
        // questions.Add(animalFood003);
        // questions.Add(animalFood004);
        // questions.Add(animalFood005);
        // questions.Add(animalFood006);
        // questions = questions.OrderBy(x => System.Guid.NewGuid()).ToList();
    }
}