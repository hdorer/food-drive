using System.Collections;
using System.Collections.Generic;

public struct ItemData {
    public int price { get; private set; }
    public ItemType type { get; private set; }

    public ItemData(int price, ItemType type) {
        this.price = price;
        this.type = type;
    }

    public static ItemData[] ITEM_DATA_LIST = new ItemData[(int)ItemType.NUM_ITEMS] {
        new ItemData(0, ItemType.PURPLE_SQUARE),
        new ItemData(0, ItemType.ORANGE_CIRCLE),
        new ItemData(0, ItemType.GREEN_CAPSULE),
        new ItemData(0, ItemType.RED_CIRCLE),
        new ItemData(0, ItemType.ORANGE_SQUARE)
    };
}
