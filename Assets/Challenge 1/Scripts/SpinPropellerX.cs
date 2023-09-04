using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 rotationSpeed = new Vector3(0, 0, 90);
    public GameObject propeller;
    public float torque = 300f; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
        
    }
}
