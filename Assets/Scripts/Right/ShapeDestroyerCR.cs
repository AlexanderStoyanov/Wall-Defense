using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeDestroyerCR : MonoBehaviour
{

    public GameObject shapeDestructionPoint;
    public GameObject shapeDestructionPointAlt;
    public static bool generate;

    void Start ()
    {

       shapeDestructionPoint = GameObject.Find("ShapeDestroyerCR");
    }

    void Update()
    {
        if (transform.position.x < shapeDestructionPoint.transform.position.x)
        {
            generate = true;
            ScoreManager.healthDecrease();
            GameObject.Destroy(this.gameObject);
        }
    }
}
