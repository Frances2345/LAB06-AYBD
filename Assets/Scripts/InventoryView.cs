using UnityEngine;
using TMPro;

public class InventoryView : WindowView
{
    public TextMeshProUGUI textInventory;

    public override void Setup(ScriptableObject data)
    {
        InventoryDataSO iData = (InventoryDataSO)data;
        textInventory.text = "YOUR BACKPACK:\n";

        foreach (string item in iData.itemsList)
        {
            textInventory.text = textInventory.text + ">> " + item + "\n";
        }

    }
}
