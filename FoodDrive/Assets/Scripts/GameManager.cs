using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    static GameManager instance;

    [SerializeField] Cart cart;
    public static Cart Cart { get { return instance.cart; } }

    ItemData[] itemDataList;
    public static ItemData[] ItemDataList { get { return instance.itemDataList; } }

    void Awake() {
        instance = this;

        itemDataList = new ItemData[(int)ItemType.NUM_ITEMS] {
            new ItemData(false, true, false, 3),
            new ItemData(false, false, true, 2),
            new ItemData(false, false, true, 5),
            new ItemData(false, false, true, 2),
            new ItemData(true, true, false, 2)
        };
    }
}
