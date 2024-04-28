using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class mudar_fase : MonoBehaviour
{
    
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   // public string SampleScene;

    private void OnTriggerEnter(Collider other)
    {
        // Verifica se a colisão ocorreu com um objeto com a tag "Bullet".
        if (other.gameObject.CompareTag("Player"))
        {
            // Se sim, desativa este objeto.
            
           SceneManager.LoadScene(4);

            
        }
    }
}
