using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public GameObject player;
    public Vector2 spawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col)
        {
            spawn = new Vector2(0, 0);
            player.transform.position = spawn;
            player.transform.rotation = new Quaternion(0,0,90,90);
        }
    }
}
