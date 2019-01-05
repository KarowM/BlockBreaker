using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    [SerializeField]float  screenWidthInUnits = 16;
    [SerializeField]float  minX = 1;
    [SerializeField]float  maxX = 15;

    void Start() {
        Debug.Log(Screen.width);
        Debug.Log(Screen.height);
    }

    // Update is called once per frame
    void Update() {
        Debug.Log(Input.mousePosition.x);
        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePos = new Vector2(mousePosInUnits, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnits, minX, maxX);
        transform.position = paddlePos;
    }
}
