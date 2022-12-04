using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TopDownShooter.Inventory
{
    [CreateAssetMenu(menuName = "TopDownShooter/Inventory/Player Inventory Cannon Item Data")]
    public class PlayerInventoryCannonData : AbsPlayerInventoryData<PlayerInventoryCannonMono>
    {
        public override void CreateIntoInventory(PlayerInventory targetPlayerInventory)
        {
            var instaniated = InstantiateAndInitializePrefab(targetPlayerInventory.Parent);
            Debug.Log("This class is player inventory CANNON item data");
        }
    }
}