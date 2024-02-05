using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.UI;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<WeaponSO> items = new List<WeaponSO>();
    public WeaponSO sword1;
    public WeaponSO sword2;
    public WeaponSO sword3;
    public WeaponSO sword4;


    public void Awake()
    {
        items.Add(sword1);
        items.Add(sword2);
        items.Add(sword3);
        items.Add(sword4);

        sword1.name = sword1.objectName;
        sword2.name = sword2.objectName;
        sword3.name = sword3.objectName;
    }

    private void Update()
    {

    }
}
