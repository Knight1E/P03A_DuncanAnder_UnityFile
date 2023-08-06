using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyButton : MonoBehaviour
{
    [SerializeField] private ShopView _shopView;
    [SerializeField] private ItemData _itemData01;

    [SerializeField] private int _currentPlayerMoney;
    private int _currentItemCost;

    public void purchaseAProduct(ItemData data)
    {
        _currentPlayerMoney = int.Parse(data.PlayerMoney);
        _currentItemCost = int.Parse(data.ItemCost);
        if (_currentPlayerMoney >= _currentItemCost)
        {
            Debug.Log("You can actually afford this product! Good job!");
            _shopView.updatePlayerMoney(_currentPlayerMoney.ToString());
        }
        
    }
}
