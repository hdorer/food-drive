using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    static GameManager instance;

    [SerializeField] Cart cart;
    public static Cart Cart { get { return instance.cart; } }

    [SerializeField] AudioClip[] sfx;
    public static AudioClip[] SFX { get { return instance.sfx; } }
    [SerializeField] Sprite[] sprites;
    public static Sprite[] Sprites { get { return instance.sprites; } }

    ItemData[] itemDataList;
    public static ItemData[] ItemDataList { get { return instance.itemDataList; } }

    void Awake() {
        instance = this;

        itemDataList = new ItemData[(int)ItemType.NUM_ITEMS] {
            new ItemData(false, true, false, 3, SFX[0], Sprites[0]),
            new ItemData(false, false, true, 2, SFX[1], Sprites[1]),
            new ItemData(false, false, true, 5, SFX[2], Sprites[2]),
            new ItemData(false, false, true, 2, SFX[3], Sprites[3]),
            new ItemData(true, true, false, 2, SFX[4], Sprites[4])
        };
    }
}
