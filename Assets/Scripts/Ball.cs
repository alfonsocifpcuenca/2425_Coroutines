using UnityEngine;

public class Ball : MonoBehaviour
{
    public float velocidad = 5f; 
    public float limiteDerecho = 5f; // Límite derecho
    public float limiteIzquierdo = -5f; // Límite izquierdo

    private int direccion = 1;

    void Update()
    {
        // Obtén la posición actual de la bola
        Vector3 posicion = transform.position;

        // Calcula el nuevo valor de la posición en el eje X
        float nuevaPosX = posicion.x + direccion * velocidad * Time.deltaTime;

        // Verifica si alcanzó los límites y cambia la dirección si es necesario
        if (nuevaPosX > limiteDerecho)
        {
            nuevaPosX = limiteDerecho;
            direccion = -1; // Cambia la dirección a izquierda
        }
        else if (nuevaPosX < limiteIzquierdo)
        {
            nuevaPosX = limiteIzquierdo;
            direccion = 1; // Cambia la dirección a derecha
        }

        // Asigna la nueva posición a la bola
        transform.position = new Vector3(nuevaPosX, posicion.y, posicion.z);
    }
}
