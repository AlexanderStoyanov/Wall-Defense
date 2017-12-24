using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpMove : MonoBehaviour
{

    public static float upMoveSpeed = 1;

    private Rigidbody2D that;

    // Use this for initialization
    void Start()
    {
        that = GetComponent<Rigidbody2D>();
        that.velocity = new Vector2(that.velocity.x, upMoveSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        that.velocity = new Vector2(that.velocity.x, upMoveSpeed);
    }
}
