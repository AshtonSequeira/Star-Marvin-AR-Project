using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    Transform _arCam;

    // Start is called before the first frame update
    void Start()
    {
        _arCam = GameObject.FindWithTag("MainCamera").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(_arCam);
    }
}
