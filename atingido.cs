using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class atingido : MonoBehaviour
{
    public GameObject zumbi;
    public GameObject chefao;
    public GameObject tiro;
    private int pnts_prd = 10;
    public int vida_zumbi = 30;
    private int vidtt;

     private void OnTriggerEnter(Collider collision)//void OnCollisionEnter(Collision collision)
    {
        // Verifica se a colisão ocorreu com um objeto com a tag "Bullet".
        if (collision.gameObject.CompareTag("bullet"))
        {
             vida_zumbi -= pnts_prd;
        if (vida_zumbi <= 0){
            // Se sim, desativa este objeto.            
            Destroy(zumbi);}
        }
    }

}
