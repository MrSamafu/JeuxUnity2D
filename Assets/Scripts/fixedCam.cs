using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixedCam : MonoBehaviour
{
    public GameObject player;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = new Quaternion(0, 0, 0, 0);
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -15);


    }
}
