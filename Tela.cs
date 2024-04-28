using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Tela : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       teladecoarregar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void teladecoarregar(){
        SceneManager.LoadScene(1);
    }

}
