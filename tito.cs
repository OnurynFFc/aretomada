using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class tito : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 200f;
    private int muni = 100;//variável que defin a muniução máxima
    private int muni_perdida = 5;//quanto de muniçlão é perdida quando atira
    public GameObject bateria;

    public Transform armap;
    public GameObject arma;

    public AudioSource som_tiro;//som so tiro

public ProgressBar pb;

  void Update () {

        firePoint.position = armap.position;
        firePoint.rotation = armap.rotation;
       

    if (Input.GetKeyDown(KeyCode.Mouse0)) { 
      
      if(muni >= 1){//se a munição for maior que 1, pode atirar e irá perder 5 pontos de munição
      Fire ();
      muni -= muni_perdida;
      }
      else{

      }
    }
      pb.BarValue = muni;

   }

  void Fire() {

    

    //Cria um Bullet apartir de BulletPrefab
    GameObject bullet = Instantiate (bulletPrefab, firePoint.position, firePoint.rotation);


   //Adiciona velocidade a Bullet
    bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * (bulletForce * (-1));


    //Destruir bala depois de 2 segundos
    //if(collision.gameObeject.CompareTag("bullet")){
        Destroy(bullet, 1.0f);
   // }
    
    som_tiro.Play();

  }

public void  OnTriggerEnter(Collider collision){//quando
  if (collision.gameObject.CompareTag("recarga"))
  {
    // Se o jogador colidiu com a bateria, aumenta a muniçao
      muni = 100;
      Destroy(bateria, 0.3f);
  }
}

}


