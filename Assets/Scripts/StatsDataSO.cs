using UnityEngine;

[CreateAssetMenu(fileName = "StatsDataSO", menuName = "Scriptable Objects/StatsDataSO")]
public class StatsDataSO : ScriptableObject
{
    public int life;
    public int level;
    public int strength;
    public int charisma;
    public int defense; 
    public int speed;
    public int luck;
    public int skillPoints;
}
