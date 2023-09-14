using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NauJugador : MonoBehaviour
{
    public float _velNau;

    // Start is called before the first frame update
    void Start()
    {
        _velNau = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        float direccioHoritzontal = Input.GetAxisRaw("Horizontal");
        float direccioVertical = Input.GetAxisRaw("Vertical");
        //Debug.Log(direccioHoritzontal);

        Vector2 dreccioIndicada = new Vector2(direccioHoritzontal, direccioVertical);

        Vector2 novaPos = transform.position; //retorna posicio actual de la nau.
        novaPos += dreccioIndicada * _velNau * Time.deltaTime;
        transform.position = novaPos;
    }
}
