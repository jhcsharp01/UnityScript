using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class Item
{
    public int id;
    public Sprite sprite;
    public string name;
    public string description;
}

public class PlayerUI2 : MonoBehaviour
{
    public Item[] items;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
