using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class Item : ScriptableObject
{
    public Sprite itemImage;

    public string itemName;

    [TextArea(1,4)]
    public string flavorText;

    public float cost;
}
