using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.UI;
using UnityEngine;

public class InventoryVisual : MonoBehaviour
{
    GameObject inventoryMaster;
    Inventory inventory;
    
    public void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        inventoryMaster = GameObject.Find("InventoryMaster");
        inventory = inventoryMaster.GetComponent<Inventory>();

        List<TextMeshProUGUI> inventorySpots = new List<TextMeshProUGUI>();
        for (int i = 1; i < 10; i++)
        {
            string spot = "Spot" + i.ToString() + "Text";
            TextMeshProUGUI newTextMesh = GameObject.Find(spot).GetComponent<TextMeshProUGUI>();
            inventorySpots.Add(newTextMesh);
        }
        for (int i = 0; i < inventory.items.Count; i++)
        {
            inventorySpots[i].text = inventory.items[i].objectName;

        }

    }

}
