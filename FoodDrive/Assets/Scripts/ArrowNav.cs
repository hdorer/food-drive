using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowNav : MonoBehaviour {
    [SerializeField] Transform target;

    void OnMouseDown() {
        Camera.main.GetComponent<CameraController>().Target = target;
    }
}
