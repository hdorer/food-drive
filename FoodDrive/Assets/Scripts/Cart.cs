using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cart : MonoBehaviour {
    List<ShelfItem> items = new List<ShelfItem>(); // List of all ShelfItems in the cart.
    public List<ShelfItem> Items { get { return items; } }

    [SerializeField] CartMenu menu;

    void OnMouseDown() {
        // Show the menu when the player clicks on the cart.
        menu.show();
    }

    public void addItem(ShelfItem item) {
        // Add the given ShelfItem to the list.
        items.Add(item);
    }

    public void removeItem(int index) {
        // Reactivate the ShelfItem being removed so it shows up on the shelf, then remove it from the list.
        items[index].gameObject.SetActive(true);
        items.RemoveAt(index);
    }
}
