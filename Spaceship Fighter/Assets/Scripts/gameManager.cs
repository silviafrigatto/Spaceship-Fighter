using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{

    public static gameManager instance;
    public int pontuacaoAtual;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        pontuacaoAtual = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AumentarPontuacao(int pontosParaGanhar)
    {
        pontuacaoAtual += pontosParaGanhar;
    }
}
