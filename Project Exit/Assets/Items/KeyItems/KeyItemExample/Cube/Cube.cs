using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : KeyItem
{
    public override void UseItem()
    {
        Debug.Log("So ein toller W�rfel");
        InventoryManager.DropItem(this, new Vector3(0, 5, 0));
    }
}
