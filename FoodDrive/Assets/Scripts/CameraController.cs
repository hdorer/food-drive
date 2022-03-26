using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    Transform target;
    public Transform Target {
        set { 
            target = value;
            moving = true;
        }
    }

    bool moving = false;
    [SerializeField] float moveSpeed = 5.0f;

    // Update is called once per frame
    void Update() {
        if(moving) {
            lerpCamera();
        }
    }

    void lerpCamera() {
        transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * moveSpeed);

        if(transform.position == target.position) {
            moving = false;
        }
    }
}
