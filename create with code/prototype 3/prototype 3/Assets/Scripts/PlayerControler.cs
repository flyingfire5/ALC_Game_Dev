using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAnim;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround;
    public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            //playerAnim.SetTrigger(“Jump_Trig”);
            dirtParticle.Stop();
        }
    }

    private void OnCollisionEnter(Collision soyouthinkyoucandance)
    {
        if (soyouthinkyoucandance.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParticle.Play();
        } else if (soyouthinkyoucandance.gameObject.CompareTag("Obstical"))
        {
            Debug.Log("game over");
            gameOver = true;
            explosionParticle.Play();
            dirtParticle.Stop();
        }
    }
}
