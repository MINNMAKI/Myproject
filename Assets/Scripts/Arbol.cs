using UnityEngine;

public class Arbol : MonoBehaviour
{
    public bool jugador;


    private void OnMouseDown()
    {
        if (jugador)
        {
            Destroy(gameObject);
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
