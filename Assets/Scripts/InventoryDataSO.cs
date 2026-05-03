using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InventoryDataSO", menuName = "Scriptable Objects/InventoryDataSO")]
public class InventoryDataSO : ScriptableObject
{
    public List<string> itemsList = new List<string>();
}
