using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoCarro : MonoBehaviour

{
    // Declarações
    public float velocidade = 5.0f;
    private float eixoHorizontal;
    private float eixoVertical;


    void Start()
    {
        // Ao instanciar o objeto, busca os eixos
        eixoHorizontal = Input.GetAxis("Horizontal");
        eixoVertical   = Input.GetAxis("Vertical");
    }
    void Update()
    {
        // Ao pressionar a tecla 'W':
        if(Input.GetKey(KeyCode.W))
        {
            // Translada o carro para frente
            transform.Translate(Vector3.forward * velocidade * Time.deltaTime);
        }
        // Ao pressionar a tecla 'S':
        else if(Input.GetKey(KeyCode.S))
        {
            // Translada o carro para tras
            transform.Translate(Vector3.back * velocidade * Time.deltaTime);
        }
        // Ao pressionar a tecla 'A':
        if(Input.GetKey(KeyCode.A))
        {
            // Translada o carro para esquerda
            transform.Translate(Vector3.left * velocidade * Time.deltaTime);
        }
        // Ao pressionar a tecla 'D':
        else if(Input.GetKey(KeyCode.D))
        {
            // Translada o carro para direita
            transform.Translate(Vector3.right * velocidade * Time.deltaTime);
        }
    }

}



