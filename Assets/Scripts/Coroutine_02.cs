using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coroutine_02 : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        // Obtenemos el objeto SpriteRenderer del gameobject
        this.spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnMouseDown()
    {
        // Al hacer clic, lanzamos la corrutina
        StartCoroutine(Fade());
    }

    /// <summary>
    /// Método para aplicar un efecto fade a un gameobject
    /// </summary>
    /// <returns></returns>
    IEnumerator Fade()
    {
        // Obtenemos el color del gameobject
        Color c = spriteRenderer.material.color;

        // Iteramos por su canal alfa
        for (float alpha = 1f; alpha >= 0; alpha -= 0.1f)
        {
            c.a = alpha;
            spriteRenderer.material.color = c;

            // Devolvemos la ejecución a Unity y volveremos dentro de 0.1 segundos
            yield return new WaitForSeconds(.1f);
        }

        c.a = 0f;
        spriteRenderer.material.color = c;
    }
}
