using UnityEngine;

[CreateAssetMenu(fileName = "Inventory", menuName = "Scriptable Objects/Inventory")]
public class InventoryData : ScriptableObject
{
    public int hp;
    public int str;
    public int life;
}
