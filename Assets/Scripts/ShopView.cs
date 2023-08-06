using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _itemNameUI;
    [SerializeField] private TextMeshProUGUI _itemDescriptionUI;
    [SerializeField] private TextMeshProUGUI _itemCostUI;

    public void Display(ItemData data)
    {
        _itemNameUI.text = data.ItemName;
        _itemDescriptionUI.text = data.ItemDescription;
        _itemCostUI.text = data.ItemCost;
    }
}
