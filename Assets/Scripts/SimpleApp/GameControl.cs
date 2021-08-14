using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameControl : MonoBehaviour
{
    public static GameControl control;

    public string playerName;
    public static bool animalName001known,
                        animalName002known,
                        animalName003known,
                        animalName004known,
                        animalName005known,
                        animalName006known,
                        animalName007known,
                        animalName008known,
                        animalName009known,
                        animalName010known,
                        animalName011known,
                        animalName012known,
                        animalName013known,
                        animalName014known,
                        animalName015known,
                        animalName016known,
                        animalName017known,
                        animalName018known,
                        animalName019known,
                        animalName020known,
                        animalName021known,
                        animalName022known,
                        animalName023known;


    void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }
    }

    public void Save()
    {
        Debug.Log("saving");

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

        PlayerData data = new PlayerData();
        data.playerName = playerName;
        data.animalName001known = animalName001known;
        data.animalName002known = animalName002known;
        data.animalName003known = animalName003known;
        data.animalName004known = animalName004known;
        data.animalName005known = animalName005known;
        data.animalName006known = animalName006known;
        data.animalName007known = animalName007known;
        data.animalName008known = animalName008known;
        data.animalName009known = animalName009known;
        data.animalName010known = animalName010known;
        data.animalName011known = animalName011known;
        data.animalName012known = animalName012known;
        data.animalName013known = animalName013known;
        data.animalName014known = animalName014known;
        data.animalName015known = animalName015known;
        data.animalName016known = animalName016known;
        data.animalName017known = animalName017known;
        data.animalName018known = animalName018known;
        data.animalName019known = animalName019known;
        data.animalName020known = animalName020known;
        data.animalName021known = animalName021known;
        data.animalName022known = animalName022known;
        data.animalName023known = animalName023known;

        bf.Serialize(file, data);
        file.Close();
    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            playerName = data.playerName;

            animalName001known = data.animalName001known;
            animalName002known = data.animalName002known;
            animalName003known = data.animalName003known;
            animalName004known = data.animalName004known;
            animalName005known = data.animalName005known;
            animalName006known = data.animalName006known;
            animalName007known = data.animalName007known;
            animalName008known = data.animalName008known;
            animalName009known = data.animalName009known;
            animalName010known = data.animalName010known;
            animalName011known = data.animalName011known;
            animalName012known = data.animalName012known;
            animalName013known = data.animalName013known;
            animalName014known = data.animalName014known;
            animalName015known = data.animalName015known;
            animalName016known = data.animalName016known;
            animalName017known = data.animalName017known;
            animalName018known = data.animalName018known;
            animalName019known = data.animalName019known;
            animalName020known = data.animalName020known;
            animalName021known = data.animalName021known;
            animalName022known = data.animalName022known;
            animalName023known = data.animalName023known;
        }
    }
}

[Serializable]
class PlayerData
{
    public string playerName;
    public bool animalName001known;
    public bool animalName002known;
    public bool animalName003known;
    public bool animalName004known;
    public bool animalName005known;
    public bool animalName006known;
    public bool animalName007known;
    public bool animalName008known;
    public bool animalName009known;
    public bool animalName010known;
    public bool animalName011known;
    public bool animalName012known;
    public bool animalName013known;
    public bool animalName014known;
    public bool animalName015known;
    public bool animalName016known;
    public bool animalName017known;
    public bool animalName018known;
    public bool animalName019known;
    public bool animalName020known;
    public bool animalName021known;
    public bool animalName022known;
    public bool animalName023known;
}

