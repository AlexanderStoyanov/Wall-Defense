using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownMove : MonoBehaviour
{

    public static float downMoveSpeed = -1;

    private Rigidbody2D that;

	// Use this for initialization
	void Start ()
    {
        that = GetComponent<Rigidbody2D>();
        that.velocity = new Vector2(that.velocity.x, downMoveSpeed);
    }
	
	// Update is called once per frame
	void Update ()
    {
        that.velocity = new Vector2(that.velocity.x, downMoveSpeed);
    }
}
