using UnityEngine;

public class StatsModifier : MonoBehaviour
{
    public StatsDataSO statsData;
    public WindowView windowView;

    private void AddPoint(ref int statVariable)
    {
        if (statsData == null || windowView == null)
        {
            Debug.Log("No se hayan referencias");
            return;
        }

        if (statsData.skillPoints > 0)
        {
            statVariable++;
            statsData.skillPoints--;

            windowView.Setup(statsData);
        }
        else
        {
            Debug.Log("No hay puntos");
        }
    }

    public void UpgradeLife()
    {
        AddPoint(ref statsData.life);
    }

    public void UpgradeLvl()
    {
        AddPoint(ref statsData.level);
    }

    public void UpgradeStr()
    {
        AddPoint(ref statsData.strength);
    }

    public void UpgradeCha()
    {
        AddPoint(ref statsData.charisma);
    }

    public void UpgradeDef()
    {
        AddPoint(ref statsData.defense);
    }

    public void UpgradeSpd()
    {
        AddPoint(ref statsData.speed);
    }

    public void UpgradeLuc()
    {
        AddPoint(ref statsData.luck);
    }

    public void UpgradeSkp()
    {
        AddPoint(ref statsData.skillPoints);
    }

    public void DebugResetPoints()
    {
        statsData.skillPoints = 10;
        windowView.Setup(statsData);
    }



}
