using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class NPC : MonoBehaviour
{
    public InputActionReference interact;
    public GameObject cuadroTexto;
    public TextMeshProUGUI dialogo;
    public string mensaje;
    bool jugador;


    private void Start()
    {
        if (cuadroTexto != null)
        {
            cuadroTexto.SetActive(false);
        }
    }

    private void Update()
    {
        bool teclapresionada = interact != null && interact.action.triggered;

        if (teclapresionada && jugador)
        {
            bool activoCuadro = cuadroTexto.activeSelf;
            cuadroTexto.SetActive(!activoCuadro);

            if (!activoCuadro)
            {
                dialogo.text = mensaje;
            }
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
        if (collision.CompareTag("Player"))
        {
            jugador = false;
            cuadroTexto.gameObject.SetActive(false);
        }
    }
}
