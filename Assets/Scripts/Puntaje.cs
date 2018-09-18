using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Agregar la libreria para el manejo de la UI (User Interface, Interfaz de Usuario), es decir, los textos
using UnityEngine.UI;

public class Puntaje : MonoBehaviour {
    // Variable para llevar el puntaje con numeros
    public int puntaje;
    // Referenciamos el texto que creamos para mostrar el puntaje
    public Text textoPuntaje;
    // Funcion que se ejecuta en cada cuadro del juego
    private void Update()
    {
        // Modificamos el texto del puntaje por el puntaje una vez convertido a texto
        textoPuntaje.text = puntaje.ToString();
    }
    // Funcion que se ejecuta cuando atravieza otro objeto
    private void OnTriggerEnter2D(Collider2D otro)
    {
        // Sumamos 1 un punto más en el puntaje con numeros
        puntaje++;
        // Destruimos el obstaculo una vez contabilizado
        Destroy(otro.gameObject);
    }
}
