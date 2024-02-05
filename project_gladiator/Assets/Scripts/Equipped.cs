using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Equipped : MonoBehaviour
{
    Inventory inventory;
    GameObject inventoryMaster;

    GameObject equipped1;
    GameObject equipped2;
    GameObject equipped3;
    GameObject weapon;

    TextMeshProUGUI equipped1Text;
    TextMeshProUGUI equipped2Text;
    TextMeshProUGUI equipped3Text;
    TextMeshProUGUI weaponNameText;

    // Start is called before the first frame update
    void Start()
    {
        inventoryMaster = GameObject.Find("InventoryMaster");
        inventory = inventoryMaster.GetComponent<Inventory>();

        equipped1 = GameObject.Find("StrengthText");
        equipped2 = GameObject.Find("AgilityText");
        equipped3 = GameObject.Find("IntText");
        weapon = GameObject.Find("WeaponName");

        equipped1Text = equipped1.GetComponent<TextMeshProUGUI>();
        equipped2Text = equipped2.GetComponent<TextMeshProUGUI>();
        equipped3Text = equipped3.GetComponent<TextMeshProUGUI>();
        weaponNameText = weapon.GetComponent<TextMeshProUGUI>();

        equipped1Text.text = "0";
        equipped2Text.text = "0";
        equipped3Text.text = "0";
        weaponNameText.text = "None";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ButtonOneClick()
    {
        equipped1Text.text = inventory.items[0].strengthModifier.ToString();
        equipped2Text.text = inventory.items[0].agilityModifier.ToString();
        equipped3Text.text = inventory.items[0].intModifier.ToString();
        weaponNameText.text = inventory.items[0].objectName.ToString();
    }

    public void ButtonTwoClick()
    {
        equipped1Text.text = inventory.items[1].strengthModifier.ToString();
        equipped2Text.text = inventory.items[1].agilityModifier.ToString();
        equipped3Text.text = inventory.items[1].intModifier.ToString();
        weaponNameText.text = inventory.items[1].objectName.ToString();
    }

    public void ButtonThreeClick()
    {
        equipped1Text.text = inventory.items[2].strengthModifier.ToString();
        equipped2Text.text = inventory.items[2].agilityModifier.ToString();
        equipped3Text.text = inventory.items[2].intModifier.ToString();
        weaponNameText.text = inventory.items[2].objectName.ToString();
    }

    public void ButtonFourClick()
    {
        equipped1Text.text = inventory.items[3].strengthModifier.ToString();
        equipped2Text.text = inventory.items[3].agilityModifier.ToString();
        equipped3Text.text = inventory.items[3].intModifier.ToString();
        weaponNameText.text = inventory.items[3].objectName.ToString();
    }

}
