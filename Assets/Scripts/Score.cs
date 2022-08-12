using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Logica de la puntuación
public class Score : MonoBehaviour
{

    Text score;
    int scorePoints = 1000;



    void Start()
    {
        score = this.gameObject.GetComponent<Text>();

        score.text = scorePoints.ToString();

    }

    // Update is called once per frame

    //Metodo para moficiar la puntuación
    public void ScoreModification(int points)
    {


        scorePoints = scorePoints + points;


        score.text = scorePoints.ToString();


    }
    
    //Metodo para obtener la modificación
    public int GetScore()
    {

        return scorePoints;
    }

}
