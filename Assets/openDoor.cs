using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    public GameObject door;
    public float speed = 10f;
    public float doorPlaceY;
    public float doorPlaceX;
    // Start is called before the first frame update
    void Start()
    {
        doorPlaceY = door.transform.position.y;
        doorPlaceX = door.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        door.transform.position = new Vector2(doorPlaceX, doorPlaceY + 6); 
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        door.transform.position = new Vector2(doorPlaceX, doorPlaceY);  
    }
}
