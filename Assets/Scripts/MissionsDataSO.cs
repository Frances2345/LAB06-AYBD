using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MissionsDataSO", menuName = "Scriptable Objects/MissionsDataSO")]
public class MissionsDataSO : ScriptableObject
{
    public List<string> missionList = new List<string>();
}
