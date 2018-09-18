using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Agregamos la siguiente libreria para poder manejar el UI (User Interface, Interfaz de Usuario)
using UnityEngine.UI;

public class Jugador : MonoBehaviour {
    // Creamos variables publicas para controlar la velocidad, cuanto queremos que suba 
    // o baje el jugador y los limites de altura
    public float velocidad;
    public float incremento;
    public float maxY;
    public float minY;
    // Creamos una variable para guardar la proxima posición a la cual nos movemos
    private Vector2 nuevaPosicion;
    // Variable numerica que representa la vida del jugador
    public int vida;
    // Referenciamos el efecto para movernos, la animación de la camara y el texto que muestra la vida
    public GameObject moveEffect;
    public Animator camAnim;
    public Text textoVida;
    // Referenciamos los objetos spawner y textoRestart
    public GameObject spawner;
    public GameObject textoRestart;

    // Funcion que se ejecuta en cada cuadro del juego
    private void Update()
    {
        // Condicion si la vida es menor o igual a 0
        if (vida <= 0) {
            // Descativamos la creacion de obstaculos
            spawner.SetActive(false);
            // Activamos el texto de reiniciar
            textoRestart.SetActive(true);
            // Destruimos al jugador
            Destroy(gameObject);
        }
        // Asignamos al texto de la vida un nuevo valor segun nuestra variable numerica
        // vida transformada a texto
        textoVida.text = vida.ToString();
        // Movemos al jugador desde la posicion en la que se encuentra hacia la nueva posicion a la velocidad
        // que elegimos
        transform.position = Vector2.MoveTowards(transform.position, nuevaPosicion, velocidad * Time.deltaTime);
        // Condición si apretamos la tecla flecha hacia arriba y no estamos en el limite superior
        if (Input.GetKeyDown("up") && transform.position.y < maxY) {
            // Activamos la animación shake
            camAnim.SetTrigger("shake");
            // Instanciamos el efecto de particulas en la posicion del jugador sin ninguna rotacion
            Instantiate(moveEffect, transform.position, Quaternion.identity);
            // Guardamos la nueva posicion en la variable nuevaPosicion
            nuevaPosicion = new Vector2(transform.position.x, transform.position.y + incremento);
        }
        // Condición si apretamos la tecla flecha hacia abajo y no estamos en el limite inferior
        if (Input.GetKeyDown("down") && transform.position.y > minY) {
            // Activamos la animación shake
            camAnim.SetTrigger("shake");
            // Instanciamos el efecto de particulas en la posicion del jugador sin ninguna rotacion
            Instantiate(moveEffect, transform.position, Quaternion.identity);
            // Guardamos la nueva posicion en la variable nuevaPosicion
            nuevaPosicion = new Vector2(transform.position.x, transform.position.y - incremento);
        }
    }
}
