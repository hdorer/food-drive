using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CartMenu : MonoBehaviour
{
    Cart cart;
    [SerializeField] Image[] images;

    // Start is called before the first frame update
    void Awake()
    {
        cart = GameObject.Find("Cart").GetComponent<Cart>();
        gameObject.SetActive(false);
    }

    public void show() {
        gameObject.SetActive(true);
        updateMenu();
    }

    public void hide() {
        gameObject.SetActive(false);
    }

    public void updateMenu() {
        for(int i = 0; i < images.Length; i++) {
            if(i < cart.Items.Count) {
                images[i].gameObject.SetActive(true);
                images[i].sprite = cart.Items[i].GetComponent<SpriteRenderer>().sprite;
                images[i].color = cart.Items[i].GetComponent<SpriteRenderer>().color;
            } else {
                images[i].gameObject.SetActive(false);
            }
        }
    }

    public void removeItem(int index) {
        cart.removeItem(index);
        updateMenu();
    }
}
