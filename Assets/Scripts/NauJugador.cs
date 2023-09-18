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

        Vector2 dreccioIndicada = new Vector2(direccioHoritzontal, direccioVertical).normalized;
        SpriteRenderer SpriteRenderer = GetComponent<SpriteRenderer>();

        float anchura = SpriteRenderer.bounds.size.x / 2;
        float altura = SpriteRenderer.bounds.size.y / 2;

        float limitEsquerraX = -Camera.main.orthographicSize * Camera.main.aspect + anchura;
        float limitDretaX = Camera.main.orthographicSize * Camera.main.aspect - anchura;

        float limitArribaY = Camera.main.orthographicSize - altura;
        float limitAbajoY = -Camera.main.orthographicSize + altura;

        Vector2 novaPos = transform.position; //retorna posicio actual de la nau.
        novaPos += dreccioIndicada * _velNau * Time.deltaTime;

        novaPos.x = Mathf.Clamp(novaPos.x, limitEsquerraX, limitDretaX);
        novaPos.y = Mathf.Clamp(novaPos.y, limitAbajoY, limitArribaY);

        transform.position = novaPos;
    }
}
