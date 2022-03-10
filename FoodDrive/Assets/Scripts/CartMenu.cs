using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CartMenu : MonoBehaviour
{
    [SerializeField] Image[] images; // List of sprite "slots".
                                     // May need refactor: the menu should create the objects aligned to a grid mathematically,
                                     // saving memory on objects that don't need to exist.

    public void show() {
        // Activate the object, updating its contents along the way.
        gameObject.SetActive(true);
        updateMenu();
    }

    public void hide() {
        // Deactivate the object.
        gameObject.SetActive(false);
    }

    public void updateMenu() {
        // Iterate through the images in the list, doing the following...
        for(int i = 0; i < images.Length; i++) {
            if(i < GameManager.Cart.Items.Count) {
                // If there is an item in the cart that corresponds to this image, activate it, and set its sprite to match that
                // of the ShelfItem.
                images[i].gameObject.SetActive(true);
                images[i].sprite = GameManager.Cart.Items[i].GetComponent<SpriteRenderer>().sprite;
                images[i].color = GameManager.Cart.Items[i].GetComponent<SpriteRenderer>().color;
            } else {
                // Otherwise, make sure it is deactivated.
                images[i].gameObject.SetActive(false);
            }
        }
    }

    public void removeItem(int index) {
        // Remove an item from the GameManager.Cart and update the menu display.
        GameManager.Cart.removeItem(index);
        updateMenu();
    }
}
