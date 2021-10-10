using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Se realiza el resize");
        Debug.Log(transform.localScale);
        transform.localScale = new Vector3(8, 8, 8);
        transform.position = new Vector3(-24.5f, 4, -16.4f);
        Debug.Log(transform.localScale);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Se realiza el movimiento");
        Debug.Log(transform.position);
        transform.position += new Vector3(0.01f, 0, 0);
        Debug.Log(transform.position);

    }
}
