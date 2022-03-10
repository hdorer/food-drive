using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    static GameManager instance;

    [SerializeField] Cart cart;
    public static Cart Cart { get { return instance.cart; } }

    void Awake() {
        instance = this;
    }
}
