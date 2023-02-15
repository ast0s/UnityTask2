using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class JsonLoadSave : MonoBehaviour
{
    public InputField nameInputField;
    public InputField descriptionInputField;

    public void SaveToJson()
    {
        SomeData sd = new SomeData();

        sd.Name = nameInputField.text;
        sd.Description = descriptionInputField.text;

        File.WriteAllText(Application.streamingAssetsPath + "/SomeDataFile.json", JsonUtility.ToJson(sd, true));
    }
    public void LoadFromJson()
    {
        SomeData sd = JsonUtility.FromJson<SomeData>(File.ReadAllText(Application.streamingAssetsPath + "/SomeDataFile.json"));

        nameInputField.text = sd.Name;
        descriptionInputField.text = sd.Description;
    }
}

[Serializable]
public class SomeData
{
    [SerializeField]
    private string _name;
    [SerializeField]
    private string _description;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }
}
