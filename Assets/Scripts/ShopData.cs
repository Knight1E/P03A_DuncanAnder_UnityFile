using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopData : MonoBehaviour
{
    [SerializeField] private ShopView _shopView;
    [SerializeField] private ItemData _itemData01;

    [SerializeField] private int _currentPlayerMoney;
    private int _currentItemCost;

    private void Start()
    {
        _currentPlayerMoney = int.Parse(_itemData01.PlayerMoney);
        _shopView.Display(_itemData01);
        
    }

    public void purchaseAProduct()
    {
        _currentItemCost = int.Parse(_itemData01.ItemCost);
        if (_currentPlayerMoney >= _currentItemCost)
        {
            Debug.Log("You can actually afford this product! Good job!");
            _currentPlayerMoney -= _currentItemCost;
            _shopView.updatePlayerMoney(_currentPlayerMoney.ToString());
        }
        else
        {
            Debug.Log("You can't afford this product.");
        }
    }
}
