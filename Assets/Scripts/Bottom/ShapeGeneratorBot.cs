using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeGeneratorBot : MonoBehaviour
{

    public GameObject shape1;
    public GameObject shape2;
    public GameObject shape3;
    public GameObject shape4;

    public static GameObject current;

    public static bool botLaneEmpty = true;

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
            //botLaneEmpty = false;
            //ShapeDestroyerCB.generate = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (ShapeDestroyerCB.generate || DiamondDestroyer.generateB || TriangleDestroyer.generateB || PuzzleDestroyer.generateB || Shape1Destroyer.generateB && ScoreManager.scoreCount > 751)
        {
            if (ShapeGeneratorTop.topShapePos(ShapeGeneratorTop.current) < 4)
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
                botLaneEmpty = false;
                ShapeDestroyerCB.generate = false;
                DiamondDestroyer.generateB = false;
                TriangleDestroyer.generateB = false;
                PuzzleDestroyer.generateB = false;
                Shape1Destroyer.generateB = false;
            }
        }
        else if (botLaneEmpty && ScoreManager.scoreCount > 751 && ShapeGeneratorTop.topShapePos(ShapeGeneratorTop.current) < 4)
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
            botLaneEmpty = false;
        }
    }

    public static float botShapePos(GameObject shape)
    {
        if (shape == null)
        {
            return 0;
        }
        else return shape.transform.position.y;
    }
}
