using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{

    public class PlayerInventory : MonoBehaviour
    {
        [SerializeField] private AbstractBasePlayerInventoryItemData[] _inventoryItemDataArray;
        public Transform Parent;
        private void Start()
        {
            InitializeInventory(_inventoryItemDataArray);
        }
        public void InitializeInventory(AbstractBasePlayerInventoryItemData[] inventoryItemDataArrays)
        {
            for (int i = 0; i < inventoryItemDataArrays.Length; i++)
            {
                inventoryItemDataArrays[i].CreateIntoInventory(this);
            }
        }

    }
}