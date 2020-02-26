using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 13f;
    public int jumph = 400;
    public Animator anim;
    private string direction; 
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        anim.SetBool("Run", false);
        direction = "droite";

    }

    // Update is called once per frame
    void Update()
    {
        

        


        if (Input.GetKey(KeyCode.Q))
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
            anim.SetBool("Run", true);
            if(direction == "droite")
            {
                spriteRenderer.transform.rotation = new Quaternion(0,180,0,0);
                direction = "gauche";
            }
            
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
            anim.SetBool("Run", true);
            if (direction == "gauche")
            {
                spriteRenderer.transform.rotation = new Quaternion(0, 0, 0, 0);
                direction = "droite";
            }
            
        }
        else
        {
            anim.SetBool("Run", false);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumph));
            anim.SetBool("Run", false);
            print("jump");

            StartCoroutine(jump());

        }




    }
    IEnumerator jump()
    {
        
        yield return new WaitForSeconds(2);
        print("coucou");  

    }
}
