using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsSkills : MonoBehaviour
{
    public enum StatsType
    {
        WeaponDamage_1,
        WeaponDamage_2, 
        WeaponDamage_3,
        WeaponSpeed_1,
        WeaponSpeed_2,
        WeaponSpeed_3,
        MovementSpeed_1,
        MovementSpeed_2,
        MovementSpeed_3,
    }

    private List<StatsType> unlockedStatsTypeList;

    public PlayerStatsSkills()
    {
        unlockedStatsTypeList = new List<StatsType>();
    }

    public void UnlockStat(StatsType type)
    {
        unlockedStatsTypeList.Add(type);
    }

    public bool IsStatUnlocked(StatsType type)
    {
        return unlockedStatsTypeList.Contains(type);
    }
}
