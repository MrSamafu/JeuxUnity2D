using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptInputRedFloor : MonoBehaviour
{
    public GameObject leSol;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("t"))
        {
            leSol.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
