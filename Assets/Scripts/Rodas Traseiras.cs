using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodasTraseiras : MonoBehaviour
{

    public float sensibilidadeRotacaoRoda = 5000.0f;

    // Update is called once per frame
    void Update()
    {
        // Ao pressionar a tecla 'W':
        if(Input.GetKey(KeyCode.W))
        {
            // Rotaciona a roda
            transform.Rotate(-sensibilidadeRotacaoRoda * 1000000, 0, 0);
        }
        // Ao pressionar a tecla 'S':
        else if(Input.GetKey(KeyCode.S))
        {
            // Rotaciona a roda
            transform.Rotate(sensibilidadeRotacaoRoda * 1000000, 0, 0);
        }
    }
}
