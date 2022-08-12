using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//Logica del juego
public class ControladorJuego : MonoBehaviour
{

    int numberEnemies;
    public GameObject player;
   
    public Score score;
    bool canWin = true;

    public Text textLevelLoad;
    public Animator transition;

    //buscar los objetos en la escena necessarios para controlar el juego
    private void Start()
    {
        score = GameObject.Find("ScoreNumber").GetComponent<Score>();

        player = GameObject.FindGameObjectWithTag("Player");


    }

    private void Update()
    {
        //mantener acutalizado el numero de enemigos que hay
        numberEnemies = GameObject.FindGameObjectsWithTag("Enemi").Length;

        //actualizar la puntuación
        if (score.GetScore() <= 0 )
        {
            canWin = false;
            StartCoroutine(GameOver());

        }

        //comprobar si no quedan enemigos i si se puede ganar
        if (numberEnemies <= 0 && canWin != false)
        {
            //Si la pantalla no es la pantalla final ir al siguiente nivel
            if (SceneManager.GetActiveScene().buildIndex != 8)
            {
                StartCoroutine(LoadNextLvl(SceneManager.GetActiveScene().buildIndex + 1));

                
            }
            //si es la pantalla final acabar el juego
            else
            {
                StartCoroutine(FinalJUego());
            }

        }

    }

    //empezar el nivel activando el canWin ya que se habran cargado todos los enemigos

    public void OnLevelWasLoaded(int level)
    {
        transition.SetTrigger("Start");
        if(SceneManager.GetActiveScene().buildIndex != 2 )
        {

            canWin = true;
        }

    }

    //Cargar los niveles desactivando el canWin, sino al no haber enemigos entre cargas detecta que has ganado
    IEnumerator LoadNextLvl(int index)
    {
        canWin = false;
        transition.SetTrigger("Finish");

        textLevelLoad.text = "LEVEL " + (SceneManager.GetActiveScene().buildIndex - 1);

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(index);


    }

    //cargar la pantalla de Game over desactivando el canWin, sino al no haber enemigos entre cargas detecta que has ganado

    IEnumerator GameOver()
    {
        canWin = false;
        player.GetComponent<DeathPlayer>().Kill();

        yield return new WaitForSeconds(3);

        transition.SetTrigger("Finish");

        textLevelLoad.text = "GAME OVER";

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(2);

    }


    //Cargar la pantalla de final de juego desactivando canWin, sino al no haber enemigos entre cargas detecta que has ganado
    IEnumerator FinalJUego()
    {
        canWin = false;
        transition.SetTrigger("Finish");

        textLevelLoad.text = "CONGRATULATIONS!!";

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(2);

    }

}
