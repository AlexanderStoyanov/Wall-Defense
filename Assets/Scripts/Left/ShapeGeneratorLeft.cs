using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeGeneratorLeft : MonoBehaviour
{

    public GameObject shape1;
    public GameObject shape2;
    public GameObject shape3;
    public GameObject shape4;

    public static GameObject current;

    public static bool leftLaneEmpty = true;

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
        //leftLaneEmpty = false;
        //ShapeDestroyerCL.generate = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (ShapeDestroyerCL.generate || DiamondDestroyer.generateL || TriangleDestroyer.generateL || PuzzleDestroyer.generateL || Shape1Destroyer.generateL && ScoreManager.scoreCount > 251)
        {
            if (ShapeGeneratorRight.rightShapePos(ShapeGeneratorRight.current) < 4)
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
                leftLaneEmpty = false;
                ShapeDestroyerCL.generate = false;
                DiamondDestroyer.generateL = false;
                TriangleDestroyer.generateL = false;
                PuzzleDestroyer.generateL = false;
                Shape1Destroyer.generateL = false;
            }
        }
        else if (leftLaneEmpty && ScoreManager.scoreCount > 251 && ShapeGeneratorRight.rightShapePos(ShapeGeneratorRight.current) < 4)
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
            leftLaneEmpty = false;
        }
    }

    public static float leftShapePos(GameObject shape)
    {
        if (shape == null)
        {
            return 0;
        }
        else return shape.transform.position.x;
    }
}
