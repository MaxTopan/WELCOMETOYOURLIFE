using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    private Animator anim;
    public float speed = 1.0f;
    Vector3 movement = Vector3.zero;
    //private Rigidbody2D phys;

    // Use this for initialization
    void Start()
    {
        movement.x = speed / 10;
        anim = GetComponent<Animator>();
        //phys = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            // walk right
            gameObject.transform.position += movement;
            anim.SetInteger("animState", 2);
            
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position -= movement;
            // walk left

            anim.SetInteger("animState", 1);
        }
        else
        {

            anim.SetInteger("animState", 0);
        }
    }
}
