using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//metodo para activar la muerte de los objetos puntuables (lo dejé de esta forma por sia acaso en un futuro queremos añadir objetos que no sean enemigos pero que puedan dar puntuaciones)
public class DeathEnemie : MonoBehaviour
{
    
    public GameObject deathParticle;
    Score score;
    public int points;
    public void Start()
    {
        //Detecta al inicio el objeto Score
        score = GameObject.Find("ScoreNumber").GetComponent<Score>();
     
    }


    //la logica de la muerte del enemigo
    public void Death()
    {
        //activar explosión
        GameObject explosion = (GameObject)Instantiate(deathParticle);

        //colocar la explosión en el lugar del objeto

        explosion.transform.position = gameObject.transform.position;

        //modificar el Score 

        score.ScoreModification(points);

       
        //Destruir el objeto
        Destroy(this.gameObject);


    }


}
