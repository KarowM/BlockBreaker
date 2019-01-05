using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    // Start is called before the first frame update
    [SerializeField]float  screenWidthInUnits = 16f;

    void Start() {
        Debug.Log(Screen.width);
        Debug.Log(Screen.height);
    }

    // Update is called once per frame
    void Update() {
        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        transform.position = new Vector2(mousePosInUnits, transform.position.y); ;
    }
}
