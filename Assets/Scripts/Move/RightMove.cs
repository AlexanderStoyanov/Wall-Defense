using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightMove : MonoBehaviour {

    //needs to be negative to move left
    public static float rightMoveSpeed = 1;

    private Rigidbody2D that;

    // Use this for initialization
    void Start()
    {
        that = GetComponent<Rigidbody2D>();
        that.velocity = new Vector2(rightMoveSpeed, that.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        that.velocity = new Vector2(rightMoveSpeed, that.velocity.y);
    }
}
