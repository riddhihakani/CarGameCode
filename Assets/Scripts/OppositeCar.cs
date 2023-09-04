using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OppositeCar : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
