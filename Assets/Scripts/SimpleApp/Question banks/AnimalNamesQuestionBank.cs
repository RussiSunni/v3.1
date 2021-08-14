using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class AnimalNamesQuestionBank : SimpleQuestion
{
    public static List<SimpleQuestion> questions = new List<SimpleQuestion>();
    public static SimpleQuestion animalName001 = new SimpleQuestion();
    public static SimpleQuestion animalName002 = new SimpleQuestion();
    public static SimpleQuestion animalName003 = new SimpleQuestion();
    public static SimpleQuestion animalName004 = new SimpleQuestion();
    public static SimpleQuestion animalName005 = new SimpleQuestion();
    public static SimpleQuestion animalName006 = new SimpleQuestion();
    public static SimpleQuestion animalName007 = new SimpleQuestion();
    public static SimpleQuestion animalName008 = new SimpleQuestion();
    public static SimpleQuestion animalName009 = new SimpleQuestion();
    public static SimpleQuestion animalName010 = new SimpleQuestion();
    public static SimpleQuestion animalName011 = new SimpleQuestion();
    public static SimpleQuestion animalName012 = new SimpleQuestion();
    public static SimpleQuestion animalName013 = new SimpleQuestion();
    public static SimpleQuestion animalName014 = new SimpleQuestion();
    public static SimpleQuestion animalName015 = new SimpleQuestion();
    public static SimpleQuestion animalName016 = new SimpleQuestion();
    public static SimpleQuestion animalName017 = new SimpleQuestion();
    public static SimpleQuestion animalName018 = new SimpleQuestion();
    public static SimpleQuestion animalName019 = new SimpleQuestion();
    public static SimpleQuestion animalName020 = new SimpleQuestion();
    public static SimpleQuestion animalName021 = new SimpleQuestion();
    public static SimpleQuestion animalName022 = new SimpleQuestion();
    public static SimpleQuestion animalName023 = new SimpleQuestion();

    void Start()
    {
        animalName001 = new SimpleQuestion()
        {
            number = 1,
            questionName = "cat",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Cat"),
            answerOptions = new List<string>()
        {
            "bear",
            "dog",
            "cat",
            "horse"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName002 = new SimpleQuestion()
        {
            number = 2,
            questionName = "dog",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Dog"),
            answerOptions = new List<string>()
        {
            "mouse",
            "cat",
            "duck",
            "dog"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName003 = new SimpleQuestion()
        {
            number = 3,
            questionName = "horse",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Horse"),
            answerOptions = new List<string>()
        {
            "dog",
            "horse",
            "mouse",
            "ant"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName004 = new SimpleQuestion()
        {
            number = 4,
            questionName = "bear",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Bear"),
            answerOptions = new List<string>()
        {
            "bear",
            "horse",
            "mouse",
            "ant"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName005 = new SimpleQuestion()
        {
            number = 5,
            questionName = "wolf",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Wolf"),
            answerOptions = new List<string>()
        {
            "cat",
            "wolf",
            "mouse",
            "ant"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName006 = new SimpleQuestion()
        {
            number = 6,
            questionName = "zebra",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Zebra"),
            answerOptions = new List<string>()
        {
            "dog",
            "horse",
            "mouse",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName007 = new SimpleQuestion()
        {
            number = 7,
            questionName = "owl",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Owl"),
            answerOptions = new List<string>()
        {
            "dog",
            "horse",
            "owl",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName008 = new SimpleQuestion()
        {
            number = 8,
            questionName = "monkey",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Monkey"),
            answerOptions = new List<string>()
        {
            "monkey",
            "horse",
            "owl",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName009 = new SimpleQuestion()
        {
            number = 9,
            questionName = "squirrel",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Squirrel"),
            answerOptions = new List<string>()
        {
            "monkey",
            "squirrel",
            "owl",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName010 = new SimpleQuestion()
        {
            number = 10,
            questionName = "giraffe",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Giraffe"),
            answerOptions = new List<string>()
        {
            "giraffe",
            "squirrel",
            "owl",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName011 = new SimpleQuestion()
        {
            number = 11,
            questionName = "lion",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Lion"),
            answerOptions = new List<string>()
        {
            "giraffe",
            "squirrel",
            "lion",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName012 = new SimpleQuestion()
        {
            number = 12,
            questionName = "alligator",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Alligator"),
            answerOptions = new List<string>()
        {
            "alligator",
            "squirrel",
            "lion",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName013 = new SimpleQuestion()
        {
            number = 13,
            questionName = "rhinoceros",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Rhinoceros"),
            answerOptions = new List<string>()
        {
            "rhinoceros",
            "squirrel",
            "lion",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName014 = new SimpleQuestion()
        {
            number = 14,
            questionName = "duck",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Duck"),
            answerOptions = new List<string>()
        {
            "rhinoceros",
            "squirrel",
            "lion",
            "duck"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName015 = new SimpleQuestion()
        {
            number = 15,
            questionName = "pig",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Pig"),
            answerOptions = new List<string>()
        {
            "rhinoceros",
            "squirrel",
            "pig",
            "duck"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName016 = new SimpleQuestion()
        {
            number = 16,
            questionName = "donkey",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Donkey"),
            answerOptions = new List<string>()
        {
            "rhinoceros",
            "squirrel",
            "pig",
            "donkey"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName017 = new SimpleQuestion()
        {
            number = 17,
            questionName = "rabbit",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Rabbit"),
            answerOptions = new List<string>()
        {
            "rabbit",
            "squirrel",
            "pig",
            "donkey"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName018 = new SimpleQuestion()
        {
            number = 18,
            questionName = "frog",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Frog"),
            answerOptions = new List<string>()
        {
            "rabbit",
            "squirrel",
            "pig",
            "frog"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName019 = new SimpleQuestion()
        {
            number = 19,
            questionName = "tiger",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Tiger"),
            answerOptions = new List<string>()
        {
            "tiger",
            "squirrel",
            "pig",
            "frog"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName020 = new SimpleQuestion()
        {
            number = 20,
            questionName = "goat",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Goat"),
            answerOptions = new List<string>()
        {
            "tiger",
            "squirrel",
            "goat",
            "frog"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName021 = new SimpleQuestion()
        {
            number = 21,
            questionName = "chicken",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Chicken"),
            answerOptions = new List<string>()
        {
            "tiger",
            "squirrel",
            "goat",
            "chicken"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName022 = new SimpleQuestion()
        {
            number = 22,
            questionName = "elephant",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Elephant"),
            answerOptions = new List<string>()
        {
            "tiger",
            "elephant",
            "goat",
            "chicken"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName023 = new SimpleQuestion()
        {
            number = 23,
            questionName = "iguana",
            sprite = Resources.Load<Sprite>("SimpleApp/Questions/Iguana"),
            answerOptions = new List<string>()
        {
            "tiger",
            "elephant",
            "goat",
            "iguana"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };
    }

    public static void LoadQuestionList()
    {
        if (GameControl.animalName001known == false)
            questions.Add(animalName001);

        if (!GameControl.animalName002known)
            questions.Add(animalName002);

        if (!GameControl.animalName003known)
            questions.Add(animalName003);

        if (!GameControl.animalName004known)
            questions.Add(animalName004);

        if (!GameControl.animalName005known)
            questions.Add(animalName005);

        if (!GameControl.animalName006known)
            questions.Add(animalName006);

        if (!GameControl.animalName007known)
            questions.Add(animalName007);

        if (!GameControl.animalName008known)
            questions.Add(animalName008);

        if (!GameControl.animalName009known)
            questions.Add(animalName009);

        if (!GameControl.animalName010known)
            questions.Add(animalName010);

        if (!GameControl.animalName011known)
            questions.Add(animalName011);

        if (!GameControl.animalName012known)
            questions.Add(animalName012);

        if (!GameControl.animalName013known)
            questions.Add(animalName013);

        if (!GameControl.animalName014known)
            questions.Add(animalName014);

        if (!GameControl.animalName015known)
            questions.Add(animalName015);

        if (!GameControl.animalName016known)
            questions.Add(animalName016);

        if (!GameControl.animalName017known)
            questions.Add(animalName017);

        if (!GameControl.animalName018known)
            questions.Add(animalName018);

        if (!GameControl.animalName019known)
            questions.Add(animalName019);

        if (!GameControl.animalName020known)
            questions.Add(animalName020);

        if (!GameControl.animalName021known)
            questions.Add(animalName021);

        if (!GameControl.animalName022known)
            questions.Add(animalName022);

        if (!GameControl.animalName023known)
            questions.Add(animalName023);

        questions = questions.OrderBy(x => System.Guid.NewGuid()).ToList();

        Debug.Log(questions.Count);
    }
}

