using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MovimentacaoCarro : MonoBehaviour

{
    // Declarações
    public float velocidade = 7.5f;
    public float sensibilidadeRotacao = 0.5f;
    private float eixoHorizontal;
    private float eixoVertical;

    public GameObject camera3Pessoa;
    public GameObject camera1Pessoa;

    void Start()
    {
        // Ao instanciar o objeto, busca os eixos
        eixoHorizontal = Input.GetAxis("Horizontal");
        eixoVertical   = Input.GetAxis("Vertical");

        camera3Pessoa.GetComponent<Camera>().enabled = true;
        camera1Pessoa.GetComponent<Camera>().enabled = false;
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
            // Rotaciona o carro sentido anti-horario
            transform.Rotate(0, -sensibilidadeRotacao, 0);
        }
        // Ao pressionar a tecla 'D':
        else if(Input.GetKey(KeyCode.D))
        {
            // Rotaciona o carro sentido horario
            transform.Rotate(0, sensibilidadeRotacao, 0);
        }

        // Ao apertar a barra de apagar
        if(Input.GetKey(KeyCode.Backspace)) {
            // Reinicia a Cena atual
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        // Ao apertar C altera entre as cameras
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Ativa Primeira Pessoa
            if(camera3Pessoa.GetComponent<Camera>().enabled) {
                camera3Pessoa.GetComponent<Camera>().enabled = false;
                camera1Pessoa.GetComponent<Camera>().enabled = true;
            } 
            // Ativa Terceira Pessoa
            else {
                camera3Pessoa.GetComponent<Camera>().enabled = true;
                camera1Pessoa.GetComponent<Camera>().enabled = false;
            }
        }
    }
}



