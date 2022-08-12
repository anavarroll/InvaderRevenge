using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//Mostrar i guardar la puntaución final
public class FinalScore : MonoBehaviour
{
    Text scoreFinal;
    Text score;
   

    void Awake()
    {

        //Sitio donde saldra la puntuación
        scoreFinal = this.gameObject.GetComponent<Text>();

        //Canvas donde se encuentra la puntaución
        score = GameObject.Find("CanvasJuego").GetComponentInChildren<Text>();

        //Envair ela puntaución que tiene el jugador para mostrarlo
        scoreFinal.text = score.text;
    }

   //Falta metodo para guardar las puntauciones


}
