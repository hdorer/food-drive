using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cart : MonoBehaviour {
    List<ShelfItem> items = new List<ShelfItem>();
    public List<ShelfItem> Items { get { return items; } }

    [SerializeField] CartMenu menu;

    void OnMouseDown() {
        menu.show();
    }

    public void addItem(ShelfItem item) {
        items.Add(item);
    }

    public void removeItem(int index) {
        items[index].gameObject.SetActive(true);
        items.RemoveAt(index);
    }
}
