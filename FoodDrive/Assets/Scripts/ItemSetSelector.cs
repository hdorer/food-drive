using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemSetSelector : MonoBehaviour {
    [SerializeField] int itemSet;

    void OnMouseDown() {
        GameManager.ItemSet = itemSet;
        SceneManager.LoadScene("Aisles");
    }
}
