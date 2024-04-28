using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class funcoes : MonoBehaviour
{
   //public File Jogo_map = Assets/Scenes/Jogo_map.unity;
    //public Button botao_jg;
    //public SceneManagement Jogo_map;

   /* private void Start()
    {
        botao_jg.onClick = new Button.ButtonClickedEvent();
        botao_jg.onClick.AddListener(() => Mudarcena(SceneManagement.LoadScene(Jogo_map.unity)));
    }*/

    public void Mudarcena(){
        
      SceneManager.LoadScene(3);

    }

}
