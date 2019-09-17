using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed;
    public float turnspeed;
    public float horiImput;
    public float forwardImput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        horiImput = Input.GetAxis("Horizontal");
        forwardImput = Input.GetAxis("Vertical");
        //move the car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardImput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * horiImput);
    }
}
