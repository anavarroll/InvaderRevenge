using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Logica de la muerte del jugador
public class DeathPlayer : MonoBehaviour
{
    public GameObject deathParticle;

    
    public void Kill()
    {

        GameObject explosion = (GameObject)Instantiate(deathParticle);

        explosion.transform.position = gameObject.transform.position;

        Destroy(this.gameObject);

    }
}
