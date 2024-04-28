using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_fps : MonoBehaviour
{

    public Transform Corpoc;
    public Transform Cabecac;
    public Transform Armac;//arma

    float sensX = 5f;
    float sensY = 5f;

    float rotcX = 10;
    float rotcY = 0;

    float angleYmin = -30;//angulo em graus 
    float angleYmax =  30;

    float suavrotX = 5f;
    float suavroty = 5f;

    float suavCfx = 1.5f;
    float suavCfy = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;


    }

    private void LateUpdate(){
        transform.position = Cabecac.position;
        //transform.position = Armac.position;//arma
    }

    // Update is called once per frame
    void Update()
    {
         
        float verticalDelta = Input.GetAxisRaw("Mouse Y") * sensY;
        float horizontalDelta = Input.GetAxisRaw("Mouse X") * sensX;

        suavrotX = Mathf.Lerp(suavrotX, horizontalDelta, suavCfx);
        suavroty = Mathf.Lerp(suavroty, verticalDelta, suavCfy);


        rotcX += horizontalDelta;
        rotcY += verticalDelta;

        rotcY = Mathf.Clamp(rotcY, angleYmin, angleYmax);

        Corpoc.localEulerAngles = new Vector3(0, rotcX, 0);
        Armac.localEulerAngles = new Vector3(-rotcY, 0 ,0);//tirar se der erro
        


        transform.localEulerAngles = new Vector3(-rotcY, rotcX, 0);



    }
}