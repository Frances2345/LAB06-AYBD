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

    public TextMeshProUGUI[] missionTexts;

    public TextMeshProUGUI[] itemTexts;


    public void Setup(ScriptableObject data)
    {
        if (data == null) return;

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
            for (int i = 0; i < missionTexts.Length; i++)
            {
                if (i < m.missionList.Count)
                {
                    missionTexts[i].text = (i + 1) + ". " + m.missionList[i];
                }
                else
                {
                    missionTexts[i].text = "";
                }
            }


        }
        else if (data is InventoryDataSO inv)
        {
            for (int i = 0; i < itemTexts.Length; i++)
            {
                if (i < inv.itemsList.Count)
                {
                    itemTexts[i].text = "- " + inv.itemsList[i];
                }
                else
                {
                    itemTexts[i].text = "---";
                }
            }
        }
    }

}
