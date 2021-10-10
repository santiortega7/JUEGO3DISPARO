using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float velocidadDis = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        disparo();
    }
    void disparo()
    {
        transform.Translate(Vector3.up * velocidadDis * Time.deltaTime);

        if(transform.position.y >= 4.509)
        {
            Destroy(this.gameObject);
        }
    }
}
