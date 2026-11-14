using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    public GameObject menuPanel, OptionsPanel, GameOverPanel;

    public int floresObjetivo, ArrbolesObjetivo;
    bool msioncompletada;

    private void Start()
    {
        menuPanel.SetActive(true);
        OptionsPanel.SetActive(false);
        GameOverPanel.SetActive(false);
        msioncompletada = false;
    }

    private void Update()
    {
        if(Flower.flowers >= floresObjetivo && Arbol.arbol >= ArrbolesObjetivo)
        {
            msioncompletada = true;
        }

        if (msioncompletada)
        {
            ActiveGameOver();
        }
    }


    void ActiveGameOver()
    {
        GameOverPanel.SetActive (true);
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
        menuPanel.SetActive (false);
    }

    public void OnRegresar()
    {
        OptionsPanel.SetActive(false);
        menuPanel.SetActive(true);
    }

    public void OnMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void OnExit()
    {
        Debug.Log("Cerrando");
        Application.Quit();
    }
}
