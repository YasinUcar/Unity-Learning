using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TopDownShooter.Inventory
{
    public enum InventoryItemDataType { Cannon, Body }

    public abstract class AbsPlayerInventoryData<T> : AbstractBasePlayerInventoryItemData where T : AbsPlayerInventoryDataMono // monoDeğerlere ulaşmak için T'yi elde ettik
    {
        [SerializeField] protected string _itemId;
        [SerializeField] protected InventoryItemDataType _inventoryItemDataType;
        [SerializeField] protected T _prefab;
       
        protected T InstantiateAndInitializePrefab(Transform parent)
        {
          return  Instantiate(_prefab, parent);
        }
    }
}
