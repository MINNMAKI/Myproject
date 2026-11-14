using TMPro;
using UnityEngine;

public class Flower : MonoBehaviour
{
    public static int flowers;
    public TextMeshProUGUI contador;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ActualizarTexto();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            flowers += 1; ;
            ActualizarTexto();
            Destroy(gameObject);
        }
    }


    void ActualizarTexto()
    {
        if(contador != null)
        {
            contador.text = "Flores: " + flowers;
        }

    }
}
