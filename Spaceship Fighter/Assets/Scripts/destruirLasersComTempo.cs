using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruirLasersComTempo : MonoBehaviour
{

    public float tempoDeVida;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, tempoDeVida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
