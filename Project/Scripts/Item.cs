using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "GameName/Inventory/Item")]
public class Item : ScriptableObject

{
    public new string name;
    public int weight;
    public int baseValue;
}
