using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//IA del enemigo tipo 2, se quedará quiro disparando
public class EnemiA2 : MonoBehaviour
{
    public GameObject BalaInicio;
    public GameObject BalaPrefab;
    public float BalaVelocidad;
    //La variable que modifical el tiempo de disparo
    public float cadenciaDisparo;
    private float siguienteDisparo;

    //La puntuación que quiratá el enemigo
    public int BulletDamage;

    // Update is called once per frame
    void Update()
    {
        //Dispara cad cierto tiempos
        if (Time.time > siguienteDisparo)

        {
            siguienteDisparo = Time.time + cadenciaDisparo;
            GameObject BalaTemporal = Instantiate(BalaPrefab, BalaInicio.transform.position, new Quaternion(0, 0, 90, 0)) as GameObject;
            BalaTemporal.GetComponent<EnemieBullet>().BulletDamage =  -BulletDamage;


            Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

            rb.AddForce(-transform.forward * BalaVelocidad);

            Destroy(BalaTemporal, 5.0f);

        }
    }
}
