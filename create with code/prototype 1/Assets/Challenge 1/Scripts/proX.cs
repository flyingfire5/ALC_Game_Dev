using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proX : MonoBehaviour
{
    public float spin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // makes propeler spin
        transform.Rotate(Vector3.forward * spin * Time.deltaTime);
    }
}
