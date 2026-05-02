using UnityEngine;
using TMPro;

public class WindowView : MonoBehaviour
{
    public TextMeshProUGUI txtLife;
    public TextMeshProUGUI txtLvl;
    public TextMeshProUGUI txtStr;
    public TextMeshProUGUI txtCha;
    public TextMeshProUGUI txtDef;
    public TextMeshProUGUI txtSpd;
    public TextMeshProUGUI txtLuc;
    public TextMeshProUGUI txtPts;

    public TextMeshProUGUI txtBodyText;

    public void Setup(ScriptableObject data)
    {
        if(data is StatsDataSO s)
        {
            txtLife.text = "LIFE: " + s.life;
            txtLvl.text = "LEVEL: " + s.level;
            txtStr.text = "STRENGTH: " + s.strength;
            txtCha.text = "CHARISMA: " + s.charisma;
            txtDef.text = "DEFENSE: " + s.defense;
            txtSpd.text = "SPEED: " + s.speed;
            txtLuc.text = "LUCK: " + s.luck;
            txtPts.text = "POINTS: " + s.skillPoints;
        }
        else if (data is MissionsDataSO m)
        {
            txtBodyText.text = m.content;
        }
        else if (data is InventoryDataSO i)
        {
            txtBodyText.text = i.itemsList;
        }
    }

}
