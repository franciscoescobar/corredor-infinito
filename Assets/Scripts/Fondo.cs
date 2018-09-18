using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fondo : MonoBehaviour {

    // Variable para la velocidad del fondo
    public float velocidad;
    // Variables para reiniciar el mismo escenario
    public float finalX;
    public float principioX;

    // Funcion que se ejecuta una vez en cada cuadro del juego
    private void Update()
    {
        // Trasladamos el fondo hacia la izquierda controlando la velocidad con la variable creada
        transform.Translate(Vector2.left * velocidad * Time.deltaTime);
        // Condicion de que si el fondo llega al final
        if (transform.position.x < finalX) {
            // Si el fondo termino lo enviamos al comienzo
            transform.position = new Vector2(principioX, transform.position.y);
        } 
    }
}
