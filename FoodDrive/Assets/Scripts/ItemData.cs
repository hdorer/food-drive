using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct ItemData {
    public bool breakfast { get; private set; }
    public bool lunch { get; private set; }
    public bool dinner { get; private set; }
    public int price { get; private set; } // How much the item costs.

    // Default constructor
    public ItemData(bool breakfast, bool lunch, bool dinner, int price) {
        this.breakfast = breakfast;
        this.lunch = lunch;
        this.dinner = dinner;
        this.price = price;
    }
}
