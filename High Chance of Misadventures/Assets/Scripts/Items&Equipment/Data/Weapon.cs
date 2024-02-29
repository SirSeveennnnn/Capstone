using System;
using UnityEngine;

[Serializable]
public class Weapon 
{
    [SerializeField] private WeaponDataSO weaponData;
    [SerializeField] private int weaponLevel;
    [SerializeField] private int bonusATK;
    [SerializeField] private TempSpecialSkillDataSO specialSkillData;

    public Weapon(WeaponDataSO weaponData, int weaponLevel, int bonusATK, TempSpecialSkillDataSO specialSkillData)
    {
        this.weaponData = weaponData;
        this.weaponLevel = weaponLevel;
        this.bonusATK = bonusATK;
        this.specialSkillData = specialSkillData;
    }

    public WeaponDataSO GetWeaponData() => weaponData;

    public int GetWeaponLevel() => weaponLevel;

    public int GetBonusATK() => bonusATK;

    public TempSpecialSkillDataSO GetSpecialSkillData() => specialSkillData;
}
