using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeGeneratorRight : MonoBehaviour
{

    public GameObject shape1;
    public GameObject shape2;
    public GameObject shape3;
    public GameObject shape4;

    public static GameObject current;

    public static bool rightLaneEmpty = true;

    private int shapeNumber;


    // Use this for initialization
    void Start()
    {
        //shapeNumber = Random.Range(1, 5);
        //switch (shapeNumber)
        //{
        //    case 1:
        //        current = Instantiate(shape1, transform.position, transform.rotation);
        //        break;
        //    case 2:
        //        current = Instantiate(shape2, transform.position, transform.rotation);
        //        break;
        //    case 3:
        //        current = Instantiate(shape3, transform.position, transform.rotation);
        //        break;
        //    case 4:
        //        current = Instantiate(shape4, transform.position, transform.rotation);
        //        break;
        //}
        //rightLaneEmpty = false;
        //ShapeDestroyerCR.generate = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (ShapeDestroyerCR.generate || DiamondDestroyer.generateR || TriangleDestroyer.generateR || PuzzleDestroyer.generateR || Shape1Destroyer.generateR && ScoreManager.scoreCount > 501)
        {
            if (ShapeGeneratorLeft.leftShapePos(ShapeGeneratorLeft.current) > -4)
            {
                shapeNumber = Random.Range(1, 5);
                switch (shapeNumber)
                {
                    case 1:
                        current = Instantiate(shape1, transform.position, transform.rotation);
                        break;
                    case 2:
                        current = Instantiate(shape2, transform.position, transform.rotation);
                        break;
                    case 3:
                        current = Instantiate(shape3, transform.position, transform.rotation);
                        break;
                    case 4:
                        current = Instantiate(shape4, transform.position, transform.rotation);
                        break;
                }
                rightLaneEmpty = false;
                ShapeDestroyerCR.generate = false;
                DiamondDestroyer.generateR = false;
                TriangleDestroyer.generateR = false;
                PuzzleDestroyer.generateR = false;
                Shape1Destroyer.generateR = false;
            }
        }
        else if (rightLaneEmpty && ScoreManager.scoreCount > 501)
        {
            shapeNumber = Random.Range(1, 5);
            switch (shapeNumber)
            {
                case 1:
                    current = Instantiate(shape1, transform.position, transform.rotation);
                    break;
                case 2:
                    current = Instantiate(shape2, transform.position, transform.rotation);
                    break;
                case 3:
                    current = Instantiate(shape3, transform.position, transform.rotation);
                    break;
                case 4:
                    current = Instantiate(shape4, transform.position, transform.rotation);
                    break;
            }
            rightLaneEmpty = false;
        }
    }

    public static float rightShapePos(GameObject shape)
    {
        if (shape == null)
        {
            return 0;
        }
        else return shape.transform.position.x;
    }
}
