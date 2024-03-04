using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour {
    [SerializeField] string itemName;
    
    void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "Player1" || other.gameObject.name == "Player2")
        {
            Managers.Inventory.AddItem(itemName);
            Destroy(this.gameObject);
        }
    }
    
}
