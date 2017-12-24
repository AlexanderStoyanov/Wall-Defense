using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{

    public Text scoreText;
    public Text healthText;

    public static int scoreCount;
    public static int healthCount;
    public static int healthBonus;


	void Start ()
    {
        UpMove.upMoveSpeed = 1;
        DownMove.downMoveSpeed = -1;
        LeftMove.leftMoveSpeed = -1;
        RightMove.rightMoveSpeed = 1;
        healthCount = 100;
        healthBonus = 0;
        scoreCount = 0;
    }


    void Update()
    {
        scoreText.text = "Score: " + scoreCount; //score output to the screen
        healthText.text = "Health: " + healthCount; //health output to the screen
        if (healthCount < 1)
        {
            SceneManager.LoadScene("main_menu");
        }
    }

    public static void scoreIncrease()
    {
        scoreCount += 25;

        //speed increase as the score goes up
        if (scoreCount % 100 == 0 && scoreCount != 0 && scoreCount < 1001)
        {

            UpMove.upMoveSpeed += (float)0.1;
            DownMove.downMoveSpeed -= (float)0.1;
            LeftMove.leftMoveSpeed -= (float)0.1;
            RightMove.rightMoveSpeed += (float)0.1;
        }
    }

    public static void healthDecrease()
    {
        healthCount -= 5;
    }

    public static void healthIncrease()
    {
        healthBonus++;
        if (healthBonus >= 10)
        {
            healthCount += healthBonus;
            healthBonus = 0;
        }
    }

}
