using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Agregamos la libreria SceneManagement para poder manejar las escenas
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

    // Funcion que se ejecuta en cada cuadro del juego
	void Update () {
        // Condicion si apretamos la tecla R
        if (Input.GetKeyDown("r")){
            // Cargamos la escena que esta activa en este momento
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}
}
