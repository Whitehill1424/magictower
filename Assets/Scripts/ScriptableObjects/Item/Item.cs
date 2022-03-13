using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "item")]

public class Item : ScriptableObject
{
    public string objectName;
    public Sprite sprite;
    public int quantity;
    public bool stackable;
    public enum ItemType
    {
        medicine,
        atkstrong,
        dfestrong,
        agistrong,
        yellowkey,
        bluekey,
        redkey,
        hp
    }
    public ItemType itemType;

}
