using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//logica de balas enemigas
public class EnemieBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public int BulletDamage;
    Score score;
    public void Start()
    {
        score = GameObject.Find("ScoreNumber").GetComponent<Score>();

    }
    //destruir balas
    void Update()
    {
        Destroy(this.gameObject, 5.0f);
    }

    //Quita la puntuación del jugador

    private void OnTriggerEnter(Collider collision)
    {


        if (collision.transform.parent.tag == "Player")
        {

            score.ScoreModification(BulletDamage);
            Destroy(this.gameObject);
        }
    }
}
