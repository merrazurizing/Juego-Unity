using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class  ScriptCard : MonoBehaviour
{
    string card;
    bool flag=true;
    // PONER PUNTAJES DESDE EL 4 EN ADELANTE
    public void changeCardleft()
    {
        if (flag) {
            card = this.name;
            flag = false;
        }
        hideCards();
        int random = Random.Range(1, 22);
        string newcard = "Card" + random;
        GameObject.Find(newcard).transform.localScale = new Vector3(1, 1, 1);

        //int army, int pop, int church, int treasury
 
        if ("Card1" == card)
            changeScore(2, -2, 0, 0);
        if("Card2" == card)
            changeScore(-2,2, 0, 0);
        if ("Card3" == card)
            changeScore(-1, -2, 0, 3);
        if ("Card4" == card)
            changeScore(-2, 2, 0, 0);
        if ("Card5" == card)
            changeScore(3, -3, 0, 0);
        if ("Card6" == card)
            changeScore(0, -2, 0, 2);
        if ("Card7" == card)
            changeScore(3, -3, 0, 0);
        if ("Card8" == card)
            changeScore(0, 3, 0, -3);
        if ("Card9" == card)
            changeScore(0, -2, 0, 0);
        if ("Card10" == card)
            changeScore(-2, -2, -2, -2);
        if ("Card11" == card)
            changeScore(0, -2, 0, 2);
        if ("Card12" == card)
            changeScore(0, 0, -3, 0);
        if ("Card13" == card)
            changeScore(-2, -2, 0, 2);
        if ("Card14" == card)
            changeScore(0, -3, -2, 3);
        if ("Card15" == card)
            changeScore(-1, 3,3, 3);
        if ("Card16" == card)
            changeScore(2, 0, -2, -2);
        if ("Card17" == card)
            changeScore(-1, -2, -1, -1);
        if ("Card18" == card)
            changeScore(0, 2, -2, 0);
        if ("Card19" == card)
            changeScore(-2, 2, 0, 0);
        if ("Card20" == card)
            changeScore(1, 2, -2, -2);
        if ("Card21" == card)
            changeScore(2, -2, 0, 0);
        if ("Card22" == card)
            changeScore(-1, 3, 0, 0);

        card = newcard;
    }


    public void changeCardright()
    {
        if (flag)
        {
            card = this.name;
            flag = false;
        }
        hideCards();
        int random = Random.Range(1, 22);
        string newcard = "Card" + random;
        GameObject.Find(newcard).transform.localScale = new Vector3(1, 1, 1);



        if ("Card1" == card)
            changeScore(-2, 2, 0, 0);
        if ("Card2" == card)
            changeScore(2, -2, 0, 0);
        if ("Card3" == card)
            changeScore(1, 2, 0, -2);
        if ("Card4" == card)
            changeScore(2, -2, 0, 0);
        if ("Card5" == card)
            changeScore(-3, 3, 0, 0);
        if ("Card6" == card)
            changeScore(0, 2, 0, -2);
        if ("Card7" == card)
            changeScore(-3, 3, 0, 0);
        if ("Card8" == card)
            changeScore(0, -3, 0, 3);
        if ("Card9" == card)
            changeScore(0, -2, 0, 0);
        if ("Card10" == card)
            changeScore(2, 2, 2, 2);
        if ("Card11" == card)
            changeScore(0, -2, 0, 2);
        if ("Card12" == card)
            changeScore(0, 0, 3, 0);
        if ("Card13" == card)
            changeScore(2, 2, 0, -3);
        if ("Card14" == card)
            changeScore(0, 3, 2, -3);
        if ("Card15" == card)
            changeScore(3, -1, -1, -1);
        if ("Card16" == card)
            changeScore(-2, 0, 2, 2);
        if ("Card17" == card)
            changeScore(2, 1, 0, 0);
        if ("Card18" == card)
            changeScore(0, -2, 2, 0);
        if ("Card19" == card)
            changeScore(2, -2, 0, 0);
        if ("Card20" == card)
            changeScore(-1, -2, 2, 2);
        if ("Card21" == card)
            changeScore(-2, 2, 0, 0);
        if ("Card22" == card)
            changeScore(2, 1, -2, 0);
        card = newcard;
    }


    public void hideCards()
    {
        for (int i = 1; i < 22; i++)
        {
            GameObject.Find("Card" + i).transform.localScale = new Vector3(0, 1, 1);
        }
    }



    public void leftOption()
    {
        changeCardleft();
    }

    public void rightOption()
    {
        changeCardright();
    }


    public void changeScore(int army, int pop, int church, int treasury)
    {
        if (isDead(army, pop, church, treasury))
            gameOver();


        ScoreScript.armyValue += army;
        ScoreScript.populationValue += pop;
        ScoreScript.churchValue += church;
        ScoreScript.treasuryValue += treasury;
    }

    public bool isDead(int army, int pop, int church, int treasury) {
        if (ScoreScript.armyValue + army >= 10)
            return true;
        if (ScoreScript.armyValue + army <= 0)
            return true;
        if (ScoreScript.populationValue + pop >= 10)
            return true;
        if (ScoreScript.populationValue + pop <= 0)
            return true;
        if (ScoreScript.churchValue + church >= 10)
            return true;
        if (ScoreScript.churchValue + church <= 0)
            return true;

        if (ScoreScript.treasuryValue + treasury >= 10)
            return true;
        if (ScoreScript.treasuryValue + treasury <= 0)
            return true;

        return false;
    }


    public void gameOver()
    {
        SceneManager.LoadScene("GameOver");

    }

}