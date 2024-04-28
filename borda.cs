using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class borda : MonoBehaviour
{
    // Start is called before the first frame update
   /* void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
    public Transform personagem;
    public Transform checkpoint;

    private void OnTriggerEnter(Collider collision)//void OnCollisionEnter(Collision collision)
    {
        // Verifica se a colisão ocorreu com um objeto com a tag "Bullet".
        if (collision.gameObject.CompareTag("borda"))
        {
            //personagem.position = checkpoint.position;        
            SceneManager.LoadScene(1);
        }
    }
}
