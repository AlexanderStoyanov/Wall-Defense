using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondDestroyer : MonoBehaviour
{

    public GameObject RightD;
    public GameObject LeftD;
    public GameObject TopD;
    public GameObject BotD;

    public static bool generateR;
    public static bool generateL;
    public static bool generateT;
    public static bool generateB;


    void Start ()
    {
        generateR = false;
        generateL = false;
        generateT = false;
        generateB = false;
    }
	

	void Update ()
    {
        try
        {
            RightD = GameObject.FindGameObjectWithTag("RightD");
            if (RightD.transform.position.x < transform.position.x && RightD.transform.position.x > 1.5 && RightD.transform.position.x < 2)
            {
                generateR = true;
                ScoreManager.scoreIncrease();
                GameObject.Destroy(RightD);
                ScoreManager.healthIncrease();
            }
        }
        catch(System.NullReferenceException e)
        {
            
        }

        try
        {
            LeftD = GameObject.FindGameObjectWithTag("LeftD");
            if (LeftD.transform.position.x > transform.position.x && LeftD.transform.position.x < -1.5 && LeftD.transform.position.x > -2)
            {
                generateL = true;
                ScoreManager.scoreIncrease();
                GameObject.Destroy(LeftD);
                ScoreManager.healthIncrease();
            }
        }
        catch (System.NullReferenceException e)
        {

        }

        try
        {
            TopD = GameObject.FindGameObjectWithTag("TopD");
            if (TopD.transform.position.y < transform.position.y && TopD.transform.position.y > 1.5 && TopD.transform.position.y < 2)
            {
                generateT = true;
                ScoreManager.scoreIncrease();
                GameObject.Destroy(TopD);
                ScoreManager.healthIncrease();
            }
        }
        catch (System.NullReferenceException e)
        {

        }

        try
        {
            BotD = GameObject.FindGameObjectWithTag("BotD");
            if (BotD.transform.position.y > transform.position.y && BotD.transform.position.y < -1.5 && BotD.transform.position.y > -2)
            {
                generateB = true;
                ScoreManager.scoreIncrease();
                GameObject.Destroy(BotD);
                ScoreManager.healthIncrease();
            }
        }
        catch (System.NullReferenceException e)
        {

        }
    }
}
