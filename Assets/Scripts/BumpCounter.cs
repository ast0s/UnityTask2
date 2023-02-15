using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class BumpCounter : MonoBehaviour
{
    public int bumpCounter;
    
    private void Start()
    {
        Load();
    }
    private void OnCollisionEnter(Collision collision)
    {
        bumpCounter++;
        Save();
    }
    public void Save()
    {
        ScoreContainer sc = new ScoreContainer();
        BinaryFormatter bf = new BinaryFormatter();
        FileStream stream = File.Open(Path.Combine(Application.persistentDataPath, "scoreContainer.dat"), FileMode.Create);
        sc.bumpCounter = bumpCounter;
        bf.Serialize(stream, sc);
        stream.Close();
    }
    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/scoreContainer.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = File.Open(Path.Combine(Application.persistentDataPath, "scoreContainer.dat"), FileMode.Open);
            ScoreContainer sc = (ScoreContainer)bf.Deserialize(stream);
            stream.Close();
            bumpCounter = sc.bumpCounter;
        }
        else
        {
            Debug.Log("Save file not found in" + Path.Combine(Application.persistentDataPath, "scoreContainer.dat"));
        }
    }
}

[Serializable]    
public class ScoreContainer
{
    public int bumpCounter;
}
