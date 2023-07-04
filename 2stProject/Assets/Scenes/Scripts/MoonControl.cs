using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonControl : MonoBehaviour
{
    public GameObject targetMoon = default;
    public GameObject targetSun = default;
    private float moonSpeed = 200.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // x축 이동
        //transform.RotateAround(Vector3.right, targetMoon.transform.position, moonSpeed * Time.deltaTime);

        // 회전
        transform.RotateAround(targetSun.transform.position, Vector3.forward, moonSpeed * Time.deltaTime);
    }
}
