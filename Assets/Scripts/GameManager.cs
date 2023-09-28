using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject naujugador;
    public GameObject Gameover;
    public GameObject titoljoc;
    public GameObject boton;
    public GameObject generadorNumeros;

    public enum EstatGameManager
    {
        Inici,
        Jugant,
        GameOver
    }
    private EstatGameManager _estatGameManager;
    // Start is called before the first frame update
    void Start()
    {
        _estatGameManager = EstatGameManager.Inici;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void ActualizaEstatGameManager()
    {
        switch (_estatGameManager)
        {
            case EstatGameManager.Inici:
                naujugador.SetActive(false);
                Gameover.SetActive(false);
                boton.SetActive(true);
                break;
            case EstatGameManager.Jugant:
                naujugador.SetActive(true);
                titoljoc.SetActive(false);
                Gameover.SetActive(false);
                boton.SetActive(false);
                generadorNumeros.GetComponent<GeneradorNumeros>().InicigenerarNum();
                break;
            case EstatGameManager.GameOver:
                naujugador.SetActive(false);
                titoljoc.SetActive(false);
                Gameover.SetActive(true);
                boton.SetActive(false);
                generadorNumeros.GetComponent<GeneradorNumeros>().pararGenNum();
                break;
        }
    }

    public void SetEstatGameManager(EstatGameManager estat) 
    {
        _estatGameManager = estat;
        ActualizaEstatGameManager();
    }

    public void PassantAEstatJugant()
    {
        _estatGameManager = EstatGameManager.Jugant;
        ActualizaEstatGameManager();
    }
}
