using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 0.18f;
    public int jumph = 400;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dp = new Vector3();

        if (Input.GetKey(KeyCode.Q))
        {
            dp.x -= speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            dp.x += speed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumph));
            print("jump");
            StartCoroutine(jump());
            
            
        }
        dp.z -= 0;
        transform.position += dp;

    }
    IEnumerator jump()
    {
        
        yield return new WaitForSeconds(2);
        print("coucou");  

    }
}
