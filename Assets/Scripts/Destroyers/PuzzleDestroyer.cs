using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleDestroyer : MonoBehaviour
{
    public GameObject RightP;
    public GameObject LeftP;
    public GameObject TopP;
    public GameObject BotP;

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
            RightP = GameObject.FindGameObjectWithTag("RightP");
            if (RightP.transform.position.x < transform.position.x && RightP.transform.position.x > 1.5 && RightP.transform.position.x < 2)
            {
                generateR = true;
                ScoreManager.scoreIncrease();
                GameObject.Destroy(RightP);
                ScoreManager.healthIncrease();
            }
        }
        catch (System.NullReferenceException e)
        {
            
        }

        try
        {
            LeftP = GameObject.FindGameObjectWithTag("LeftP");
            if (LeftP.transform.position.x > transform.position.x && LeftP.transform.position.x < -1.5 && LeftP.transform.position.x > -2)
            {
                generateL = true;
                ScoreManager.scoreIncrease();
                GameObject.Destroy(LeftP);
                ScoreManager.healthIncrease();
            }
        }
        catch (System.NullReferenceException e)
        {

        }

        try
        {
            TopP = GameObject.FindGameObjectWithTag("TopP");
            if (TopP.transform.position.y < transform.position.y && TopP.transform.position.y > 1.5 && TopP.transform.position.y < 2)
            {
                generateT = true;
                ScoreManager.scoreIncrease();
                GameObject.Destroy(TopP);
                ScoreManager.healthIncrease();
            }
        }
        catch (System.NullReferenceException e)
        {

        }

        try
        {
            BotP = GameObject.FindGameObjectWithTag("BotP");
            if (BotP.transform.position.y > transform.position.y && BotP.transform.position.y < -1.5 && BotP.transform.position.y > -2)
            {
                generateB = true;
                ScoreManager.scoreIncrease();
                GameObject.Destroy(BotP);
                ScoreManager.healthIncrease();
            }
        }
        catch (System.NullReferenceException e)
        {

        }
    }
}
