using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsferaScript : MonoBehaviour
{
    private Rigidbody rb;
    public float force = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (rb)
        {
            rb.AddForce(Input.GetAxis("Horizontal") * force, 0, Input.GetAxis("Vertical") * force);
        }
    }
    void Update()
    {
        if (rb && Input.GetButtonDown("Jump"))
            rb.AddForce(0, force, 0, ForceMode.Impulse);
    }
}
