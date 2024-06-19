using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoment : MonoBehaviour
{
    Rigidbody2D rgb;
    Vector3 velocity;
    public Animator animator;

    float speedAmount = 5f;
    float JumpAmount = 5f;

    public GameManagerScript gm; 

    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);
        transform.position += velocity * speedAmount * Time.deltaTime;
        animator.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));

        if (Input.GetButtonDown("Jump") && Mathf.Approximately(rgb.velocity.y, 0))
        {
            rgb.AddForce(Vector3.up * JumpAmount, ForceMode2D.Impulse);
            animator.SetBool("IsJumping", true);
        }

        if (animator.GetBool("IsJumping") && Mathf.Approximately(rgb.velocity.y, 0))
        {
            animator.SetBool("IsJumping", false);
        }

        if (Input.GetAxisRaw("Horizontal")== -1) 
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else if (Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f); 
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Coin") 
        {
            gm.Coin += 1;
            Destroy(collision.gameObject);
            Debug.Log("Coins Collected");
        }
    }
}
