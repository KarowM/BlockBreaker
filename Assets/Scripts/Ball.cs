using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    [SerializeField] Paddle paddle;
    [SerializeField] float initialVelX = 2;
    [SerializeField] float initialVelY = 15;

    Vector2 paddleToBallVector;
    bool hasLaunched ;

    void Start() {
        paddleToBallVector = transform.position - paddle.transform.position;
    }

    void Update() {
        if (!hasLaunched) {
            LockBallToPaddle();
            LaunchOnClick();
        }
    }

    private void LaunchOnClick() {
        if (Input.GetMouseButtonDown(0)) {
            hasLaunched = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(initialVelX, initialVelY);
        }
    }

    private void LockBallToPaddle() {
        Vector2 paddlePos = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
    }
}
