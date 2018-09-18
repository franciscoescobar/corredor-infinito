using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
   // Variables para controlar el tiempo entre la aparación entre cada patron
    private float tiempoEntreSpawns;
    public float tiempoInicialEntreSpawns;
    // Variable para disminuir el tiempo entre la aparición de obstaculos
    public float disminuirTiempo;
    // Variable para marcar un limite de tiempo minimo entre la aparición de obstaculos
    public float timepoMinimo;
    // Variable para referenciar los patrones de obstaculos
    public GameObject[] patrones;
    // Función que se ejecuta una sola vez al comienzo del juego
    private void Start()
    {
        // Asignar el valor de una variable a otra
        tiempoEntreSpawns = tiempoInicialEntreSpawns;
    }
    // Función que se ejecuta en cada cuadro del juego
    private void Update()
    {
        // Condicion si se cumplio el tiempo para la creación de obstaculos
        if (tiempoEntreSpawns <= 0)
        {
            // Variable numerica aleatoria entre 0 y la cantidad de patrones
            int aleatorio = Random.Range(0, patrones.Length);
            // Instanciamos un patron en la posicion del objeto sin ninguna rotacion
            Instantiate(patrones[aleatorio], transform.position, Quaternion.identity);
            // Reiniciamos el tiempo para la creacion de un obstaculo
            tiempoEntreSpawns = tiempoInicialEntreSpawns;
            // Condicion de si el tiempo entre creacion es mayor al tiempo minimo
            if (tiempoInicialEntreSpawns > timepoMinimo) {
                // Disminuimos el tiempo entre creacion segun la variable disminuirTiempo
                tiempoInicialEntreSpawns -= disminuirTiempo;
            }
        }
        // Si no se cumplio el tiempo para la creacion de obstaculos
        else {
            // Actualizamos la variable segun el tiempo transcurrido
            tiempoEntreSpawns -= Time.deltaTime;
        }
    }

}
