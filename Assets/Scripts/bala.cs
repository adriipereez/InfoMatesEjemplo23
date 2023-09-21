using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    public float velocity = 5f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //La bala suba para arrriba
        Vector2 novaPos = transform.position;
        novaPos.y += velocity * Time.deltaTime;
        transform.position = novaPos;

        //eliminar copia
        float limitArribaY = Camera.main.orthographicSize;
        if (transform.position.y >= limitArribaY){
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D objecteTocat)
    {
        if (objecteTocat.tag == "Numero")
        {
            Destroy(gameObject);
        }
    }
}
