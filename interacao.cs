using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interacao : MonoBehaviour
{
     void Update() {
       if(Input.GetKeyDown(KeyCode.E)){
        float interactRange = 20f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray){
            if(collider.TryGetComponent(out NPCInteractable npcInteractable)){
                npcInteractable.Interacao();
            }
            

        }
       }
    }
}
