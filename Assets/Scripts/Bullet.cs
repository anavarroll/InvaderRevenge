using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        //destruye la bala cuando passan 5s
        Destroy(this.gameObject, 5.0f);
    }

    private void OnTriggerEnter(Collider collision)
    {

        //Destruye el enemigo que toca la bala activando el metodo de muerte del enemigo
        if (collision.tag != "Bullet" && collision.transform.parent.tag != "Player")
        {

            if (collision.GetComponentInParent<DeathEnemie>())
             {
                collision.GetComponentInParent<DeathEnemie>().Death();
                Destroy(this.gameObject);
             }
        }
    }
}
