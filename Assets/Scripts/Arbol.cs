using UnityEngine;

public class Arbol : MonoBehaviour
{
    public static int arbol;
    public bool jugador;

    private void Start()
    {
        arbol = 0;
    }
    private void OnMouseDown()
    {
        if (jugador)
        {
            Destroy(gameObject);
            arbol += 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            jugador = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")){ 
            jugador =false;
        }
    }
}
