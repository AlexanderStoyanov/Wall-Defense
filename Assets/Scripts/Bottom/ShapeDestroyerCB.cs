using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeDestroyerCB : MonoBehaviour
{

    public GameObject shapeDestructionPoint;
    public static bool generate;



    void Start ()
    {
        shapeDestructionPoint = GameObject.Find("ShapeDestroyerCB");
    }


    void Update ()
    {
        if (transform.position.y > shapeDestructionPoint.transform.position.y)
        {
            generate = true;
            ScoreManager.healthDecrease();
            GameObject.Destroy(this.gameObject);
        }
    }
}
