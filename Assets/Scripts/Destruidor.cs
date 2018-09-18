using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruidor : MonoBehaviour {
    // Variable publica para elegir el tiempo que pueden vivir los obstaculoss
    public float timepoDeVida;

    // Funcion que se ejecuta una sola vez al comienzo del juego
    private void Start()
    {
        // Destruimos los obstaculos luego del tiempo elegido
        Destroy(gameObject, timepoDeVida);
    }
}
