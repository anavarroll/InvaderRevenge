using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Elimina todos los objectos para cuando se reinicie el juego una vez se acabe
public class ResetValues : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Destroy(GameObject.Find("MainCamera"));
        Destroy(GameObject.Find("Destination"));
        Destroy(GameObject.Find("CanvasHandler"));
        Destroy(GameObject.Find("LimiteDerecho"));
        Destroy(GameObject.Find("LimiteIzquiero"));
        Destroy(GameObject.Find("Jugador"));
    }


}
