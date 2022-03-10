using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfItem : MonoBehaviour {
    Vector3 resetPoint; // Where the GameObject goes after the player drops it.
    [SerializeField] ItemType type; // What type the item is.
    ItemData data; // Item data associated with this particular object.

    void Start() {
        resetPoint = transform.position; // Set the reset point to the object's starting position.

        data = GameManager.ItemDataList[(int)type]; // Grab the data for this particular object from the static list based on the value from the enum.
        GetComponent<SpriteRenderer>().sprite = data.sprite;
    }

    public void OnMouseDrag() {
        // Make the object follow the mouse while the mouse is dragging it.
        Vector3 newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPos.z = 0;
        transform.position = newPos;
    }

    public void OnMouseUp() {
        // Call dropCheck when the player drops the object.
        dropCheck();
    }

    void dropCheck() {
        // Perform a collision check at a close radius, and store all those colliders in an array.
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.1f);

        // Iterate through each collider in the list, doing the following:
        foreach(Collider2D c in colliders) {
            // If the collider is on the cart, add the item to the cart and deactivate the object.
            if(c.gameObject.tag == "Cart") {
                c.gameObject.GetComponent<Cart>().addItem(this);
                gameObject.SetActive(false);
            }
        }
        
        // Reset the object's position to its initial position.
        transform.position = resetPoint;
    }
}