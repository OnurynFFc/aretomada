using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteractable : MonoBehaviour
{
    public Transform interacaoP;

    public void Interacao(){
        if(Input.GetKeyDown(KeyCode.E)){
           if(interacaoP.gameObject.activeSelf) {
            interacaoP.gameObject.SetActive(false);
           }
           else{
            interacaoP.gameObject.SetActive(true);
           }
        }

    }
}
