using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements.Experimental;

public class Menu : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadScene("GameScene");
    }    
    public void GoGarage()
    {
        SceneManager.LoadScene("GarageScene");
    }    
    public void QuitGame()
    {
        Application.Quit();
    }    
}
