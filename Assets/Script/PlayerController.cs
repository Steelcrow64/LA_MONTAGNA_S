using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public GameObject deathUI;

    public PauseMenu PauseMenu;

    public float speed = 1;

    Rigidbody2D rb;
    [SerializeField] Transform groundCheckCollider;
    [SerializeField] LayerMask groundLayer;

    public float groundCheckRadius = 1f;
    float horizontalValue;
    [SerializeField] float jumpPower;
    
    [SerializeField] bool isGrounded = false;
    bool facignRight = true;
    bool jump;
    bool isDead;

    private bool IsInvincible;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isDead) return;
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            if (PauseMenu.gameObject.active)
            {
                PauseMenu.Resume();
            }
            else PauseMenu.Pause();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            IsInvincible = !IsInvincible;
        }
        if (IsInvincible)
        {
            return;
        }

        horizontalValue = Input.GetAxisRaw("Horizontal");

        //If we press Jump button enable jump
        if (Input.GetButtonDown("Jump"))
            jump = true;
        //Otherwise disable it 
        else if (Input.GetButtonUp("Jump"))
            jump = false;
    }

    void FixedUpdate()
    {
        if (isDead) return;
        GroundCheck();
        Move(horizontalValue, jump);
    }

    void GroundCheck()
    {
        isGrounded = false;
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheckCollider.position, groundCheckRadius, groundLayer);
        if (colliders.Length > 0)
            isGrounded = true;
    }

    private void Move(float dir, bool jumpFlag)
    {

        if (isGrounded && jumpFlag)
        {
            isGrounded = false;
            jumpFlag = false;
            //Add jump force
            rb.AddForce(new Vector2(0f, jumpPower), ForceMode2D.Impulse);
        }

        #region Move
        //set value of x sing dir and speed
        float xVal = dir * speed * 100 * Time.fixedDeltaTime;
        //create Vec2 for the velocity 
        Vector2 targetVelocity = new Vector2(xVal, rb.velocity.y);
        //Set the player's velocity
        rb.velocity = targetVelocity;

        //if looking right and clicked left (flip to the left)
        if (facignRight && dir < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            facignRight = false;
        }
        //if looking left and clicked left (flip to the right)
        else if(!facignRight && dir > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
            facignRight = true;
        }
        #endregion         
    }

    public void Death()
    {
        if (IsInvincible)
            return;
        transform.GetChild(0).gameObject.SetActive(false);
        isDead = true;
        rb.velocity = Vector3.zero;
        rb.gravityScale = 0;
        deathUI.SetActive(true);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere (groundCheckCollider.position, groundCheckRadius);
    }
}
