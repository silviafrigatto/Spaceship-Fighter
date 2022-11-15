using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gameManager : MonoBehaviour
{

    public static gameManager instance;

    public TextMeshProUGUI textoDePontuacaoAtual;
    public int pontuacaoAtual;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        pontuacaoAtual = 0;
        textoDePontuacaoAtual.text = "<color=white>" + "SCORE: " + pontuacaoAtual + "</color>";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AumentarPontuacao(int pontosParaGanhar)
    {
        pontuacaoAtual += pontosParaGanhar;
        textoDePontuacaoAtual.text = "<color=white>" + "SCORE: " + pontuacaoAtual + "</color>";
    }
}
