using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class botao_menu : MonoBehaviour
{

    public Transform pause;
   // public Transform pause_btn;
   public float time;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       pausa_jog();

    }

    public void pausa_jog(){
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(pause.gameObject.activeSelf){
                pause.gameObject.SetActive(false);
                Time.timeScale = 1;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
               
            }
            else{
                 
                pause.gameObject.SetActive(true);
                Time.timeScale = 0;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
       }
    }

    public void INICIO(){//despause
        pause.gameObject.SetActive(false);
         Time.timeScale = 1;
         Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Mudarcena(){//volta ao menu
      SceneManager.LoadScene(0);
    }

    public void Restart(){//renicia a cena do primeiro mapa
       Time.timeScale = 1;
      SceneManager.LoadScene(1);
    }
    public void Restart_map2(){//renicia a cena do primeiro mapa
       Time.timeScale = 1;
      SceneManager.LoadScene(2);
    }

    public void sair(){//fecha o programa

        Application.Quit(); 
        
    }
}
