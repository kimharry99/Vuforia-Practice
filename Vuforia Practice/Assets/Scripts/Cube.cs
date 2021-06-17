using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField]
    private float startZ;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, startZ);
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x;
        transform.position = new Vector3(x + 0.001f * Time.deltaTime, transform.position.y, transform.position.z);
    }
}
