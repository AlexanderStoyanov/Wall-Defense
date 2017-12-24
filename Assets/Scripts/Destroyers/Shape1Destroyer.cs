using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape1Destroyer : MonoBehaviour
{

    public GameObject RightS;
    public GameObject LeftS;
    public GameObject TopS;
    public GameObject BotS;

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
            RightS = GameObject.FindGameObjectWithTag("RightS");
            if (RightS.transform.position.x < transform.position.x && RightS.transform.position.x > 1.5 && RightS.transform.position.x < 2)
            {
                generateR = true;
                ScoreManager.scoreIncrease();
                GameObject.Destroy(RightS);
                ScoreManager.healthIncrease();
            }
        }
        catch (System.NullReferenceException e)
        {
            
        }

        try
        {
            LeftS = GameObject.FindGameObjectWithTag("LeftS");
            if (LeftS.transform.position.x > transform.position.x && LeftS.transform.position.x < -1.5 && LeftS.transform.position.x > -2)
            {
                generateL = true;
                ScoreManager.scoreIncrease();
                GameObject.Destroy(LeftS);
                ScoreManager.healthIncrease();
            }
        }
        catch (System.NullReferenceException e)
        {

        }

        try
        {
            TopS = GameObject.FindGameObjectWithTag("TopS");
            if (TopS.transform.position.y < transform.position.y && TopS.transform.position.y > 1.5 && TopS.transform.position.y < 2)
            {
                generateT = true;
                ScoreManager.scoreIncrease();
                GameObject.Destroy(TopS);
                ScoreManager.healthIncrease();
            }
        }
        catch (System.NullReferenceException e)
        {

        }

        try
        {
            BotS = GameObject.FindGameObjectWithTag("BotS");
            if (BotS.transform.position.y > transform.position.y && BotS.transform.position.y < -1.5 && BotS.transform.position.y > -2)
            {
                generateB = true;
                ScoreManager.scoreIncrease();
                GameObject.Destroy(BotS);
                ScoreManager.healthIncrease();
            }
        }
        catch (System.NullReferenceException e)
        {

        }
    }
}
