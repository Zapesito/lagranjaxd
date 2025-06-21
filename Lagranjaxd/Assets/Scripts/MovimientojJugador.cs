using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientojJugador : MonoBehaviour
{
    public float sprint = 5f;
    public Rigidbody2D rg;
    public Vector2 entrada;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rg.linearVelocity = entrada * sprint;
    }
    public void  Moverse(InputAction.CallbackContext contexto){
    entrada = contexto.ReadValue<Vector2>();
    

}





}



