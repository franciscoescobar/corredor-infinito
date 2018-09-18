using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntoDeSpawn : MonoBehaviour {
    // Variable publica para referenciar al obstaculo
    public GameObject obstaculo;
    // Funcion que se ejecuta una sola vez al comienzo del juego
    private void Start()
    {
        // Instanciamos, es decir, creamos a un obstaculo en la posicion indicada sin ninguna rotación. 
        Instantiate(obstaculo, transform.position, Quaternion.identity);
    }
}
