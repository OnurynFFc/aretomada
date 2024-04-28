using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]

public class ia_z : MonoBehaviour
{
    public float speed = 3f; // Velocidade do zumbi
    public Transform player; // Referência ao transform do jogador
    //private UnityEngine.AI.NavMeshAgent navMesh;

    //aplicando gravidade para o zumbi
    float gravidade;
    float pulo;
    float alturamx_pulo = 6f;
    float tempoaltumamx = 0.35f;



    void Start()
    {
        // Encontre o GameObject do jogador pela tag "Player"
       // player = GameObject.FindGameObjectWithTag("Player").transform;
       // navMesh = GetComponent<UnityEngine.AI.NavMeshAgent> (); 

        gravidade = (-2 * alturamx_pulo) / (tempoaltumamx * tempoaltumamx);
        pulo = (2 * alturamx_pulo) / tempoaltumamx;


    }

    void Update()
    {
        // Verifique se o jogador existe (caso ele tenha sido destruído ou ainda não foi criado)
        if (player == null)
        {
            return;
        }
        // Direção para o jogador
        Vector3 directionToPlayer = (player.position - transform.position).normalized;
        //navMesh.destination = player.transform.position;

        // Normalize para obter apenas a direção sem o comprimento do vetor
        directionToPlayer.Normalize();

        // Movimente o zumbi na direção do jogador
        transform.position += directionToPlayer * speed * Time.deltaTime;

        transform.LookAt(player);
        
    }
}