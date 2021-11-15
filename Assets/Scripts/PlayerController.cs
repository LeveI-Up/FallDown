using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRB;
    private Animator playerAnim;
    [SerializeField] float speed;
    [SerializeField] float velocity;
    private float axis = 1;
    [SerializeField] Animator hurtAnimator;
    [SerializeField] Score scoreField;
    public GameOver GameOver;
    [SerializeField] int spike=7;





    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerAnim = GetComponent<Animator>();
        //hurtAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        hurtAnimator.SetFloat("y", playerRB.position.y);
        hurtAnimator.SetFloat("Speed", velocity);
        if (playerRB.position.y >= spike)
        {
            GameOverScreen();
            Destroy(gameObject);
        }
        
    }

    void PlayerMovement()
    {
        velocity = Input.GetAxisRaw("Horizontal");
        playerRB.velocity = new Vector2(velocity * speed, playerRB.velocity.y);
        if (velocity != 0)
        {
            transform.localScale = new Vector3(velocity, axis, axis);
        }
    }

  public void GameOverScreen()
    {
        GameOver.Setup(scoreField.GetNumber());
    }
}
