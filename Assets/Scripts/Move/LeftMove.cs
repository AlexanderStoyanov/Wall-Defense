using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMove : MonoBehaviour {

    //needs to be negative to move left
    public static float leftMoveSpeed = -1;

    private Rigidbody2D that;

    // Use this for initialization
    void Start()
    {
        that = GetComponent<Rigidbody2D>();
        that.velocity = new Vector2(leftMoveSpeed, that.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        that.velocity = new Vector2(leftMoveSpeed, that.velocity.y);
    }
}
