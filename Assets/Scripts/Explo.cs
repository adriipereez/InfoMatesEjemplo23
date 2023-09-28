using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("destruirObje", 1f);
    }

    private void destruirObje()
    {

        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
