using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numero : MonoBehaviour
{
    private float _vel;
    private int _valorNumero;
    public Sprite[] _SpritesNumeros = new Sprite[10];
    // Start is called before the first frame update
    void Start()
    {
        _vel = 2f;

        //Cargamos una imagen de numero aleatorio
        System.Random aleatorio = new System.Random();
        _valorNumero = aleatorio.Next(0 , 10);
        //acceder al component Sprite Renderer i dentro de este el atributo Sprite
        //Hacemos gameobject y get component para coger un atributo y dentro de las flechas pones el atributo . sprite
        gameObject.GetComponent<SpriteRenderer>().sprite = _SpritesNumeros[_valorNumero];
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 novaPos = transform.position;
        novaPos.y = novaPos.y - _vel * Time.deltaTime;
        transform.position = novaPos;
        DestuyeSiSaleFuera();
    }

    private void OnTriggerEnter2D(Collider2D ObjecteTocat)
    {
        if (ObjecteTocat.tag == "bala" || ObjecteTocat.tag == "NauJugador")
        {
            Destroy(gameObject);   
        }

    }

    private void DestuyeSiSaleFuera()
    {
        Vector2 costatInferiorIzq = Camera.main.ViewportToWorldPoint(new Vector2(0,0)); 
        if (transform.position.y <= costatInferiorIzq.y) {
            Destroy(gameObject);
        }
    }
}
