using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    static GameManager instance;

    Cart cart;
    public static Cart Cart {
        get { return instance.cart; }
        set {
            if(instance.cart == null) {
                instance.cart = value;
            }
        }
    }

    ItemData[] itemDataList;
    public static ItemData[] ItemDataList { get { return instance.itemDataList; } }

    int itemSet;
    public static int ItemSet { get { return instance.itemSet; } set { instance.itemSet = value; } }

    void Awake() {
        instance = this;

        itemDataList = new ItemData[(int)ItemType.NUM_ITEMS] {
            new ItemData(false, true, false, 3), // APPLESAUCE
            new ItemData(false, false, true, 2), // CANNED_BEANS
            new ItemData(false, false, true, 5), // CANNED_CHICKEN 
            new ItemData(false, true, false, 5), // CANNED_FISH
            new ItemData(false, false, true, 4), // CANNED_MEAT
            new ItemData(false, false, true, 2), // CANNED_VEGETABLES
            new ItemData(false, false, true, 4), // COOKING_OIL
            new ItemData(false, true, false, 4), // CRACKERS
            new ItemData(false, true, true, 4), // DRIED_HERBS_SPICES
            new ItemData(true, true, false, 2), // CANNED_FRUITS
            new ItemData(true, true, false, 3), // GRANOLA_BARS
            new ItemData(false, false, true, 2), // INSTANT_MASHED_POTATOES
            new ItemData(true, true, true, 1), // INSTANT_RAMEN
            new ItemData(true, true, false, 3), // NUTS
            new ItemData(false, false, true, 2), // PASTA
            new ItemData(true, true, false, 5), // PEANUT_BUTTER
            new ItemData(false, true, true, 3), // RICE
            new ItemData(true, true, true, 4), // POWDERED_MILK
            new ItemData(false, true, true, 4), // SOUP_STEW_CHILI
            new ItemData(true, false, false, 5), // WHOLE_GRAIN_CEREAL
            new ItemData(false, false, false, 5), // GLASS_JAR
            new ItemData(false, false, false, 5), // FRESH_CHEESE
            new ItemData(false, false, false, 4), // FRESH_MILK
            new ItemData(false, false, false, 10), // BULK_RICE
            new ItemData(false, false, false, 4), // CANDY
            new ItemData(false, false, false, 12), // RAW_PRODUCE
            new ItemData(false, false, false, 3), // DRINKS
        };

        DontDestroyOnLoad(gameObject);
    }

    public static int calculateScore() {
        int score = 0;

        foreach(ShelfItem i in instance.cart.Items) {
            if(!i.Broken && i.Data.onList(instance.itemSet)) {
                score += i.Data.price;
            }
        }

        return score;
    }
}
