using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cart : MonoBehaviour {
    List<ItemType> items = new List<ItemType>();

    public void addItem(ItemType type) {
        items.Add(type);
    }
}
