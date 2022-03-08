using System.Collections;
using System.Collections.Generic;

public struct ItemData {
    public int price { get; private set; } // How much the item costs.
    public ItemType type { get; private set; } // What type the item is.

    // Default constructor
    public ItemData(int price, ItemType type) {
        this.price = price;
        this.type = type;
    }

    // Static array with data for each type of item.  Each ShelfItem will have an ItemData field which grabs data from here.
    // This is a variation on a pattern I saw in Java once, but C# is basically Java anyway.
    public static ItemData[] ITEM_DATA_LIST = new ItemData[(int)ItemType.NUM_ITEMS] {
        new ItemData(0, ItemType.PURPLE_SQUARE),
        new ItemData(0, ItemType.ORANGE_CIRCLE),
        new ItemData(0, ItemType.GREEN_CAPSULE),
        new ItemData(0, ItemType.RED_CIRCLE),
        new ItemData(0, ItemType.ORANGE_SQUARE)
    };
}
