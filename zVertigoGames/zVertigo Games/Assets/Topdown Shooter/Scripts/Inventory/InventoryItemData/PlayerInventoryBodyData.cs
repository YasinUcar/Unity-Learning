using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TopDownShooter.Inventory
{
    [CreateAssetMenu(menuName = "TopDownShooter/Inventory/Player Inventory Body Item Data")]
    public class PlayerInventoryBodyData : AbsPlayerInventoryData<PlayerInventoryBodyMono>
    {
        public override void CreateIntoInventory(PlayerInventory targetPlayerInventory)
        {
            var instaniated = InstantiateAndInitializePrefab(targetPlayerInventory.Parent);
            Debug.Log("This class is player inventory BODY item data");
        }
    }
}