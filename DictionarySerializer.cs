using System;
using System.Collections.Generic;
using UnityEngine;

public class DictionarySerializer : MonoBehaviour
{
    [SerializeField] string thisObjectName;
    [SerializeField] NewDictionary newDictionary; 
    Dictionary<string, GameObject> _objectsNames;

    void Start()
    {
        _objectsNames = newDictionary.ToDictionary();
    }
    
}

[Serializable]
public class NewDictionary
{
    [SerializeField] NewDictionaryItem[] dictionaryItems;

    public Dictionary<string, GameObject> ToDictionary()
    {
        var newDict = new Dictionary<string, GameObject>();

        foreach (var item in dictionaryItems)
        {
            newDict.Add(item.Name, item.Obj);
        }

        return newDict;
    }
}

[Serializable]
public class NewDictionaryItem
{
   [SerializeField] public string Name;
   [SerializeField] public GameObject Obj;
}
