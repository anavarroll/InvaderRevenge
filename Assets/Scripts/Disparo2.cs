using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//logica del disparo
public class Disparo2 : MonoBehaviour
{
    public GameObject BalaInicio;
    public GameObject BalaPrefab;
    public float BalaVelocidad;
    public float cadenciaDisparo;
    private float siguienteDisparo;
    public AudioClip sonidoLaser;

    AudioSource fuenteAudio;

    
    void Start()
    {
        //Detectar le fuente de sonido
        fuenteAudio = GetComponent<AudioSource>();

    }

    void Update()
    {
        //Si tocas la pantalla dispara
       foreach(Touch touch in Input.touches)
        {
            //Detectar que has tocado i que no ha pasado el tiempo de cadencia del disparo
            if (touch.phase == TouchPhase.Began && Time.time > siguienteDisparo)
            {
                //Setear Tiempo entre disparos
                siguienteDisparo = Time.time + cadenciaDisparo;
                //Crear bala
                GameObject BalaTemporal = Instantiate(BalaPrefab, BalaInicio.transform.position, BalaInicio.transform.rotation) as GameObject;

                //Activar el sonido del disparo
                LaserSound();
                //detectar el rigbody de la bala
                Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
                //añadir fuerza al rigibody de la bala para que salga hacia delante
                rb.AddForce(transform.forward * BalaVelocidad);

                //Destroy(BalaTemporal, 5.0f);

            }

        }
      

    }

    private void LaserSound ()
    {


        fuenteAudio.clip = sonidoLaser;
        fuenteAudio.Play();
    }

}