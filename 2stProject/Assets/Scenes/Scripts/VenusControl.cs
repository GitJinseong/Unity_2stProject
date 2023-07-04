using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VenusControl : MonoBehaviour
{
    private float VenusSpeed = 200.0f;

    public GameObject targetVenus = default;

    public GameObject sunObject = default;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // z√‡ ¿Ãµø
        //transform.RotateAround(targetVenus.transform.position, Vector3.forward,
        //VenusSpeed * Time.deltaTime);

        transform.RotateAround(sunObject.transform.position, Vector3.up,
        VenusSpeed * Time.deltaTime);

        //transform.RotateAround(targetVenus.transform.position, Vector3.right,
        //VenusSpeed * Time.deltaTime);

    }
}
