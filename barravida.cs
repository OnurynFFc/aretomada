using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class barravida : MonoBehaviour
{

    public GameObject zumbi;
    public ProgressBar pb;
    private int vida = 100;
    private int pontosPerdidos = 10;// Quantos pontos serão perdidos quando o jogador for atingido
    public GameObject cura;

    //posição do personagem = posição de checkpoint
    //public Transform personagem;
    //public GameObject personage;
    //public Transform checkpoint;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {     
       pb.BarValue = vida;
    }



    public void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.CompareTag("ObjetoPerigoso"))
        {
            // Se o jogador colidiu com um objeto perigoso, diminui a pontuação dele GameManager.instance.pontuacao.
            
             vida -= pontosPerdidos;
             if(vida <= 0){
                SceneManager.LoadScene(5);
             }
             // personagem.Colision
        }

        if (collision.gameObject.CompareTag("cura"))
  {
    // Se o jogador colidiu com a bateria, aumenta a muniçao
      vida = 100;
      Destroy(cura, 0.3f);
  }

}
/*
        if (collision.gameObject.CompareTag("chefão"))
        {
            // Se o jogador colidiu com um objeto perigoso, diminui a pontuação dele GameManager.instance.pontuacao.
           // int dano=(pontosPerdidos + 30);
             vida -= 30;
             if(vida <= 0){
                SceneManager.LoadScene(1);
             }
             // personagem.Colision
        }
        */

    
    
}
