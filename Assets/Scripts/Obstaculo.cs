using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour {
    // Variable para controlar la velocidad
    public float velocidad;
    // Variable para referenciar el efecto creado
    public GameObject efecto;
    // Funcion que se ejecuta una vez en cada cuadro del juego
	void Update () {
        // Movemos hacia la izquierda al obstaculo controlado con la velocidad creada
        transform.Translate(Vector2.left * velocidad * Time.deltaTime);
	}
    // Funcion que se ejecuta cuando el obstaculo es atravezado
    private void OnTriggerEnter2D(Collider2D otro)
    {
        // Condicion si el otor con el que colisionamos tiene la etiqueta Player
        if (otro.CompareTag("Player")) {
            // Le reducimos 1 de vida a la variable del scipt Jugador
            otro.GetComponent<Jugador>().vida--;
            // Activamos la animación shake del script Jugador
            otro.GetComponent<Jugador>().camAnim.SetTrigger("shake");
            // Instanciamos, es decir, creamos al efecto que habiamos referenciado donde 
            // se destruye el obstaculo sin ninguna rotacion
            Instantiate(efecto, transform.position, Quaternion.identity);
            // Destruimos el obstaculo
            Destroy(gameObject);
        }   
    }
}
