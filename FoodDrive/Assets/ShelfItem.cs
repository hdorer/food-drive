using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfItem : MonoBehaviour {
    Vector3 resetPoint;

    // Start is called before the first frame update
    void Start() {
        resetPoint = transform.position;
    }

    // Update is called once per frame
    void Update() {

    }

    public void OnMouseDrag() {
        Vector3 newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPos.z = 0;
        transform.position = newPos;
    }

    public void OnMouseUp() {
        dropCheck();
    }

    void dropCheck() {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.1f);
        foreach(Collider2D c in colliders) {
            if(c.gameObject.tag == "Cart") {
                Destroy(gameObject);
                return;
            }
        }
        
        transform.position = resetPoint;
    }
}