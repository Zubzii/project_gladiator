using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachSOs : MonoBehaviour
{
    public WeaponSO weaponSOs;

    private void Start()
    {
        if (weaponSOs != null)
        {
            Debug.Log("Data Value: " + weaponSOs.strengthModifier);
        }
    }
}
