using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeDestroyerCT : MonoBehaviour
{

    public GameObject shapeDestructionPoint;
    public GameObject diamondDestroyer;
    public static bool generate;

    void Start ()
    {

       shapeDestructionPoint = GameObject.Find("ShapeDestroyerCT");
    }


    void Update()
    {
        if (transform.position.y < shapeDestructionPoint.transform.position.y) //if shape was destroyed by the central object
        {
            generate = true;
            ScoreManager.healthDecrease();
            GameObject.Destroy(this.gameObject);
        }
    }
}
