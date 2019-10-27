using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void CarregarMenu1(){
        SceneManager.LoadScene("Menu 1");
    }

    public void CarregarMenu2(){
        SceneManager.LoadScene("Menu 2");
    }

    public void CarregarCenarios(){
        SceneManager.LoadScene("Cenários");
    }

    public void CarregarItens(){
        SceneManager.LoadScene("Itens");
    }

    public void CarregarCena1(){
        SceneManager.LoadScene("Cena 1");
    }

    public void CarregarCena2(){
        SceneManager.LoadScene("Cena 2");
    }

    public void CarregarLoja(){
        SceneManager.LoadScene("Loja");
    }

    public void Sair(){
       Debug.Log("Fechou!");
        Application.Quit();
    }

    public void CarregarItemAlcool(){
        SceneManager.LoadScene("Itens_AlcoolGel");
    }

}
