using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Data type is MeshRenderer
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] private float dropTime = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        
        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > dropTime)
        {
            //Debug.Log("Time has elapsed " + dropTime + " second(s).");
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
