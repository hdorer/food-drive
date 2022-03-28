using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSetDisplay : MonoBehaviour {
    [SerializeField] Sprite[] itemSetSprites;
    
    // Start is called before the first frame update
    void Start() {
        GetComponent<SpriteRenderer>().sprite = itemSetSprites[GameManager.ItemSet];
    }
}
