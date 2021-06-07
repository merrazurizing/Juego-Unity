using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int armyValue = 5;
    public static int populationValue = 5;
    public static int churchValue = 5;
    public static int treasuryValue = 5;
    Text Armyscore;
    Text Populationscore;
    Text Churchscore;
    Text treasuryscore;


    void Start()
    {
        //score = GetComponent<Text> ();
        Armyscore =GameObject.Find("ArmyText").GetComponent<Text>();
        Populationscore =GameObject.Find("PopulationText").GetComponent<Text>();
        Churchscore =GameObject.Find("ChurchText").GetComponent<Text>();
        treasuryscore =GameObject.Find("TreasuryText").GetComponent<Text>();
    }


    void Update()
    {
        Armyscore.text = " "+ armyValue;
        Populationscore.text = " " + populationValue;
        Churchscore.text = " " + churchValue;
        treasuryscore.text = " " + treasuryValue;
    }

    public static void resetScore()
    {
        ScoreScript.armyValue = 5;
        ScoreScript.populationValue = 5;
        ScoreScript.churchValue = 5;
        ScoreScript.treasuryValue = 5;
    }


}
