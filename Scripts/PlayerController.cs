using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravity;
    public bool isOntheGround = true;
    public bool gameOver;
    private Animator ami;
    public ParticleSystem overP;
    public ParticleSystem runP;
    private AudioSource bg;
    public GameObject ds;
    public AudioClip js;
    private AudioSource playerA;


    //public Animator ami;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravity;
        ami = GetComponent<Animator>();
        bg = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        //bg = GameObject.Find("crash").GetComponent<AudioSource>();
        playerA = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOntheGround && (ami.GetBool("Death_b") == false))
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

          //  playerA.PlayOneShot(js, 1.0f);

            isOntheGround = false;

            runP.Stop();
            ami.SetTrigger("Jump_trig");
            // js.
            // isOntheGround = true;
            playerA.PlayOneShot(js, 2);

        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOntheGround = true;
            runP.Play();

        }
        else if (collision.gameObject.CompareTag("obt"))
        {
            overP.Play();

            Debug.Log("Game Over");
            gameOver = true;
            ami.SetBool("Death_b", true);

            runP.Stop();
            bg.Stop();
            ds.GetComponent<AudioSource>().Play();

            //  ami.ResetTrigger("Jump_trig");
        }
    }
}
