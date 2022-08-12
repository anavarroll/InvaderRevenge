using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;

    public CharacterController Jugador;
    float horizontalMove;
    void Start()
    {
        Jugador = GetComponent<CharacterController>();


    }
    public void FixedUpdate()
    {
       


        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        horizontalMove = variableJoystick.Direction.y;
        Jugador.Move(new Vector3(0, 0, horizontalMove) * Time.deltaTime * speed);
        //rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
            


        
    }
}