using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.KeyCode;

public class movimento_persona : MonoBehaviour
{
    //UnityEngine.AI.NavMeshAgent persona;
    CharacterController controle;

    Vector3 forward;
    Vector3 strafe;
    Vector3 vertical;
 
    float forwardVel = -30f;
    float strafeVel = -20f;
    
    float corre;

    float gravidade;
    float pulo;
    float alturamx_pulo = 6f;
    float tempoaltumamx = 0.35f;

    //animação de movimento do personagem

    private  Animator animator;

     public AudioSource som_passo;//pega o som 

    // Start is called before the first frame update
    void Start()
    {


      //  persona = GetComponent<UnityEngine.AI.NavMeshAgent>();
        controle = GetComponent<CharacterController>();

        //animação
       animator = GetComponent<Animator>();

       //Gravidade
        gravidade = (-2 * alturamx_pulo) / (tempoaltumamx * tempoaltumamx);
        pulo = (2 * alturamx_pulo) / tempoaltumamx;

       

    }
  
  void Awake(){
    transform.tag = "Player";
  }

    // Update is called once per frame
    void Update()
    {
       
       andamento();

    }

    

    void andamento(){
        float forwardInput = Input.GetAxisRaw("Vertical");//Para frente e tras
        float strafeInput = Input.GetAxisRaw("Horizontal");//Para direita e esquerda
    
        forward = forwardInput * forwardVel * transform.forward;
        strafe = strafeInput * strafeVel * transform.right;
        corre = (forwardVel * 1.5f);//Input.KeyCode.

        if(Input.GetKey(KeyCode.LeftShift)){
            forward = forwardInput * corre * transform.forward;
           // som_passo.Play();
        }

        vertical += gravidade * Time.deltaTime * Vector3.up;
        
        if(controle.isGrounded){
            vertical =  Vector3.down;
        }

        if(Input.GetKeyDown(KeyCode.Space) && controle.isGrounded){
            vertical = pulo * Vector3.up;
        }


        Vector3 finalvelocty = forward + strafe + vertical;
        controle.Move(finalvelocty * Time.deltaTime);

         if(forwardInput>=1)
        {
          animator.SetBool("Pernamove", true);    
        }
        else
        {
          animator.SetBool("Pernamove", false);
        }


       
    }
    
}
