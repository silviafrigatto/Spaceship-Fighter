using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controleDoJogador : MonoBehaviour
{

    public Rigidbody2D oRigidBody2D;
    public GameObject laserDoJogador;
    public Transform localDoDisparoUnico;
    public float velocidadeDaNave;
    public bool temLaserDuplo;
    private Vector2 teclasApertadas;

    // Start is called before the first frame update
    void Start()
    {
        temLaserDuplo = false;
    }

    // Update is called once per frame
    void Update()
    {
        MovimentarJogador();
        AtirarLaser();
    }

    private void MovimentarJogador()
    {
        teclasApertadas = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        oRigidBody2D.velocity = teclasApertadas.normalized * velocidadeDaNave;
    }

    private void AtirarLaser()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if(temLaserDuplo == false)
            {
                Instantiate(laserDoJogador, localDoDisparoUnico.position, localDoDisparoUnico.rotation);
            }
        }
    }

}
