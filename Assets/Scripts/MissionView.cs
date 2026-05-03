using UnityEngine;
using TMPro;

public class MissionView : WindowView
{
    public TextMeshProUGUI textMissions;

    public override void Setup(ScriptableObject data)
    {
        MissionsDataSO mData = (MissionsDataSO)data;
        textMissions.text = "CURRENT MISSIONS:\n";

        foreach (string m in mData.missionList)
        {
            textMissions.text = textMissions.text + "- " + m + "\n";
        }
    }
}
