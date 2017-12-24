using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeDestroyerCL : MonoBehaviour
{
    public GameObject shapeDestructionPoint;
    public static bool generate;
    // Use this for initialization
    void Start()
    {
        shapeDestructionPoint = GameObject.Find("ShapeDestroyerCL");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > shapeDestructionPoint.transform.position.x)
        {
            generate = true;
            ScoreManager.healthDecrease();
            GameObject.Destroy(this.gameObject);
        }
    }
}
