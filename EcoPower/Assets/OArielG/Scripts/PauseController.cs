using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{    
    [SerializeField] GameObject pauseMenu;  // Asignar el panel PauseMenu a este objeto desde 
                                            // el elemento 'script' en el inspector, una vez
                                            // este script se haya asociado a los botones.
    
    public void Pause(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void goMenu(int _escena){
       
        Time.timeScale = 1f;
        SceneManager.LoadScene(_escena);
    }

    public void Audio(){
  
    }
}
