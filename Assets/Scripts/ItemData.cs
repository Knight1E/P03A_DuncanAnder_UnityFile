using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item", fileName = "ITM_")]
public class ItemData : ScriptableObject
{
    [SerializeField] private string _itemName = "";
    [Multiline]
    [SerializeField] private string _itemDescription = "";
    [SerializeField] private string _itemCost = "***";
    [SerializeField] private string _playerMoney = "***";

    public string ItemName => _itemName;
    public string ItemDescription => _itemDescription;
    public string ItemCost => _itemCost;
    public string PlayerMoney => _playerMoney;
}
