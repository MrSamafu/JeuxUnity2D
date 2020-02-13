using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 0.18f;
    public int jumph = 400;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dp = new Vector3();
        
       

        if (Input.GetKey(KeyCode.Q))
        {
            dp.x -= speed;
            //GetComponent<SpriteRenderer>().transform.localScale = new Vector2(-0.307f, 0.27f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            dp.x += speed;
            //GetComponent<SpriteRenderer>().transform.localScale = new Vector2(0.307f, 0.27f);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("jumpFlex", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumph));
            print("jump");
            
            anim.SetBool("JumpExt", true);
            anim.SetBool("jumpFlex", false);
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
