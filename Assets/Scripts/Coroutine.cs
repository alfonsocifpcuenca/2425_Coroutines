using UnityEngine;

public class Coroutine : MonoBehaviour
{
    private Renderer renderer;

    private void Start()
    {
        this.renderer = GetComponent<Renderer>();
    }
    private void OnMouseDown()
    {
        // Al hacer clic, lanzamos la corrutina
        Fade();
    }

    void Fade()
    {
        // Obtenemos el color del gameobject
        Color c = renderer.material.color;

        // Iteramos por su canal alfa
        for (float alpha = 1f; alpha >= 0; alpha -= 0.1f)
        {
            c.a = alpha;
            renderer.material.color = c;
        }

        c.a = 0f;
        renderer.material.color = c;
    }
}
