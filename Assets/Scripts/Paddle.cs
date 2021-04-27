using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    //Configuration parematers
    [SerializeField] float minX = -0.63f;
    [SerializeField] float maxX = 16.63f;
    [SerializeField] float screenWidthInUnits = 16f;
    

    void Start()
    {
        
    }

    
    void Update()
    {
        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnits, minX, maxX);
        transform.position = paddlePos;
    }
}
