using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndSceneManager : MonoBehaviour {
    [SerializeField] Text scoreText;

    void Start() {
        scoreText.text = "Your Score is: " + GameManager.calculateScore() + "/" + GameManager.Cart.MaxMoney;
    }

    public void goToTitle() {
        SceneManager.LoadScene("StartScene");
    }
}
