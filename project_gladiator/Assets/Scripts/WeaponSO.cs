using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObject", menuName = "ScriptableObject", order = 1)]
public class WeaponSO : ScriptableObject
{
    public int id;
    public string objectName;
    public int strengthModifier;
    public int agilityModifier;
    public int intModifier;
}

