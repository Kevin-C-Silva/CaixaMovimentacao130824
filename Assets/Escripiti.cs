using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escripiti : MonoBehaviour
{
    Vector3 caixa;
    // Start is called before the first frame update
    void Start()
    {
        caixa = new Vector3(0f, 1f, 0f);
        transform.position = caixa; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            caixa.z = 0.05f;
            caixa.x = 0f;
            caixa.y = 0f;
            transform.Translate(caixa);
        }
        if (Input.GetKey(KeyCode.S) )
        {
            caixa.z = -0.05f;
            caixa.x = 0f;
            caixa.y = 0f;
            transform.Translate(caixa);
        }
        if (Input.GetKey(KeyCode.A) )
        {
            caixa.z = 0f;
            caixa.x = -0.05f;
            caixa.y = 0f;
            transform.Translate(caixa);
        }
        if (Input.GetKey(KeyCode.D) )
        {
            caixa.z = 0f;
            caixa.x = 0.05f;
            caixa.y = 0f;
            transform.Translate(caixa);
        }
        caixa.z = 0f;
        caixa.x = 0f;
        caixa.y = 0f;
        /*if(caixa.x == 9.5) {

            caixa.z = 0f;
            caixa.x = 0f;
            caixa.y = 0f;
        }*/
    }
}
