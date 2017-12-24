using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleDestroyer : MonoBehaviour
{

    public GameObject RightT;
    public GameObject LeftT;
    public GameObject TopT;
    public GameObject BotT;

    public static bool generateR;
    public static bool generateL;
    public static bool generateT;
    public static bool generateB;


    void Start()
    {
        generateR = false;
        generateL = false;
        generateT = false;
        generateB = false;
    }


    void Update()
    {
        try
        {
            RightT = GameObject.FindGameObjectWithTag("RightT");
            if (RightT.transform.position.x < transform.position.x && RightT.transform.position.x > 1.5 && RightT.transform.position.x < 2)
            {
                generateR = true;
                ScoreManager.scoreIncrease();
                //ShapeGeneratorRight.current = null;
                GameObject.Destroy(RightT);
                ScoreManager.healthIncrease();
            }
        }
        catch (System.NullReferenceException e)
        {
           
        }

        try
        {
            LeftT = GameObject.FindGameObjectWithTag("LeftT");
            if (LeftT.transform.position.x > transform.position.x && LeftT.transform.position.x < -1.5 && LeftT.transform.position.x > -2)
            {
                generateL = true;
                ScoreManager.scoreIncrease();
                GameObject.Destroy(LeftT);
                ScoreManager.healthIncrease();
            }
        }
        catch (System.NullReferenceException e)
        {

        }

        try
        {
            TopT = GameObject.FindGameObjectWithTag("TopT");
            if (TopT.transform.position.y < transform.position.y && TopT.transform.position.y > 1.5 && TopT.transform.position.y < 2)
            {
                generateT = true;
                ScoreManager.scoreIncrease();
                GameObject.Destroy(TopT);
                ScoreManager.healthIncrease();
            }
        }
        catch (System.NullReferenceException e)
        {

        }

        try
        {
            BotT = GameObject.FindGameObjectWithTag("BotT");
            if (BotT.transform.position.y > transform.position.y && BotT.transform.position.y < -1.5 && BotT.transform.position.y > -2)
            {
                generateB = true;
                ScoreManager.scoreIncrease();
                GameObject.Destroy(BotT);
                ScoreManager.healthIncrease();
            }
        }
        catch (System.NullReferenceException e)
        {

        }
    }
}
