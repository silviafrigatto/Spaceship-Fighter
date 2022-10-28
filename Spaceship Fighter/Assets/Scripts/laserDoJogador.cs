using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserDoJogador : MonoBehaviour
{

    public float velocidadeDoLaser;
    public int danoParaDar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentarLaser();
    }

    private void MovimentarLaser()
    {
        transform.Translate(Vector3.up * velocidadeDoLaser * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Inimigo"))
        {
            other.gameObject.GetComponent<inimigos>().MachucarInimigo(danoParaDar);
            Destroy(this.gameObject);
        }
    }

}
