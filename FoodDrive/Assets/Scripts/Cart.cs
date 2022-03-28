using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cart : MonoBehaviour {
    List<ShelfItem> items = new List<ShelfItem>(); // List of all ShelfItems in the cart.
    public List<ShelfItem> Items { get { return items; } }

    [SerializeField] int maxMoney;
    public int MaxMoney { get { return maxMoney; } }
    int money;
    public int Money { get { return money; } }

    [SerializeField] CartMenu menu;
    [SerializeField] Text moneyText;

    void Awake() {
        GameManager.Cart = this;
    }

    void Start() {
        money = maxMoney;
    }

    void OnMouseDown() {
        // Show the menu when the player clicks on the cart.
        menu.show();
    }

    public void addItem(ShelfItem item) {
        // Add the given ShelfItem to the list.
        money -= item.Data.price;
        moneyText.text = "$" + money;
        items.Add(item);
    }

    public void removeItem(int index) {
        // Reactivate the ShelfItem being removed so it shows up on the shelf, then remove it from the list.
        items[index].gameObject.SetActive(true);
        money += items[index].Data.price;
        moneyText.text = "$" + money;
        items.RemoveAt(index);
    }
}
