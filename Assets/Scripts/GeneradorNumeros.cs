using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorNumeros : MonoBehaviour
{
    public GameObject _PrefabNumero;
    // Start is called before the first frame update
    void Start()
    {
        //Llama metodo, tarda un segundo en empezar, y cada 3 segundos
        InvokeRepeating("GenerarNumero", 1f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
 
    }  
    private void GenerarNumero()
    {
        GameObject numero = Instantiate(_PrefabNumero);
        Vector2 costatSuperiorDer = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        Vector2 costatInferiorIzq = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        numero.transform.position = new Vector2(Random.Range(costatSuperiorDer.x, costatInferiorIzq.y), costatSuperiorDer.y);
    }
}
