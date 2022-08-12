using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//EL patrón que seguira del enemigo tipo 1. Irá moviendose de manera descendente haciendo zigzag
public class EnemiIA1 : MonoBehaviour
{
    public float velocity;
    public float velocityoHorizontal;
    public int lessPoints;
    Score score;
    public GameObject deathParticle;
    float movimientoHorizontal;
    public void Start ()
    {
        score = GameObject.Find("ScoreNumber").GetComponent<Score>();
     
    }

    // Update is called once per frame
    void Update()
    {

        //Logica del movimiento
        float x = transform.position.x + -velocity * Time.deltaTime;

        if(transform.position.z >= 60 )
        {
            velocityoHorizontal *= -1;
        }
        else if (transform.position.z <= -70)
        {

            velocityoHorizontal *= -1;
        }

    

        float z = transform.position.z + velocityoHorizontal * Time.deltaTime;

        transform.position = new Vector3(x, 0, z);
        //this.gameObject.transform.position = this.gameObject.transform.position + new Vector3(-velocity* Time.deltaTime,0, 1*Mathf.Cos(Time.deltaTime * 0.1f) *0.5f);



    }
    //Hará daño al llegar al final o golpea al jugador
    private void OnTriggerEnter(Collider collision)
    {


        if (collision.tag == "Destination" || collision.transform.tag == "Player")
        {

            GameObject explosion = (GameObject)Instantiate(deathParticle);

            explosion.transform.position = gameObject.transform.position;

            score.ScoreModification(-lessPoints);




            Destroy(this.gameObject);
        }
    }
}
