using UnityEngine;

public class MenuManager : MonoBehaviour {

    public GameObject menuPanel, OptionsPanel;


    private void Start()
    {
        menuPanel.SetActive(true);
        OptionsPanel.SetActive(false);
    }



    public void OnPlay()
    {
        Debug.Log("Abriendo Juego");
        menuPanel.SetActive(false);
    }

    public void OnOptions()
    {
        Debug.Log("Abriendo Opciones");
        OptionsPanel.SetActive(true);
    }

    public void OnRegresar()
    {
        OptionsPanel.SetActive(false);
    }

    public void OnExit()
    {
        Debug.Log("Cerrando");
    }
}
