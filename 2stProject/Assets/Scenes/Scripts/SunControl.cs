using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunControl : MonoBehaviour
{
    public GameObject targetSun = default;

    private float sunSpeed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // y√‡ ¿Ãµø
        transform.RotateAround(targetSun.transform.position, Vector3.up, 
            sunSpeed * Time.deltaTime);
    }
}
