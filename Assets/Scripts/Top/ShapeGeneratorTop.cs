using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeGeneratorTop : MonoBehaviour
{

    public GameObject shape1;
    public GameObject shape2;
    public GameObject shape3;
    public GameObject shape4;

    public static GameObject current;

    public static bool topLaneEmpty = true;

    private int shapeNumber;


    // Use this for initialization
    void Start ()
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
        topLaneEmpty = false;
        ShapeDestroyerCT.generate = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        
        if (ShapeDestroyerCT.generate || DiamondDestroyer.generateT || TriangleDestroyer.generateT || PuzzleDestroyer.generateT || Shape1Destroyer.generateT)
        {
            if (ShapeGeneratorBot.botShapePos(ShapeGeneratorBot.current) < 4)
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
                topLaneEmpty = false;
                ShapeDestroyerCT.generate = false;
                DiamondDestroyer.generateT = false;
                TriangleDestroyer.generateT = false;
                PuzzleDestroyer.generateT = false;
                Shape1Destroyer.generateT = false;
            }
        }
	}

    public static float topShapePos(GameObject shape)
    {
        if (shape == null)
        {
            return 0;
        }
        else return shape.transform.position.y;
    }
}
