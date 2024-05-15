using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI chestText;

    void Start()
    {
        chestText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateChestText(PlayerInventory playerInventory)
    {
        chestText.text = playerInventory.NumberOfChests.ToString();
    }
}
