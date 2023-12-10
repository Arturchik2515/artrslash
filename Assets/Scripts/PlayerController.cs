using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /*
    private float speed2;
    // видно в Unity, видно из любого скрипта
    public float speed1;
    */
    // видно в Unity, видно только в этом скрипте
    
    [SerializeField] private float speed;
    [SerializeField] private float jumpStrenght = 5;
    [SerializeField] private GameObject groundPoint;
    [SerializeField] private Vector2 groundPointSize;
    [SerializeField] private LayerMask groundLayerMask;
    [SerializeField] private KeyCode attackKey = KeyCode.Mouse0;
    [SerializeField] private GameObject attackPoint;
    [SerializeField] private float attackPointRadius;


    private Rigidbody2D rb;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        // (x, y) -> (1, 0)

        rb.velocity = new Vector2(moveX * speed, rb.velocity.y);
        animator.SetFloat("Speed", Mathf.Abs(moveX));

        Vector3 theScale = transform.localScale;
        if (moveX > 0)
        {
            theScale.x = Mathf.Abs(theScale.x);
        }
        else if (moveX < 0)
        {
            theScale.x = -Mathf.Abs(theScale.x);
        }
        transform.localScale = theScale;

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.AddForce(transform.up * jumpStrenght, ForceMode2D.Impulse);
        }

        Attack();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(groundPoint.transform.position, groundPointSize);

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPoint.transform.position, attackPointRadius);
    }

    bool IsGrounded()
    {
        // Скастовать прямоугольник 
        RaycastHit2D hit = Physics2D.BoxCast(groundPoint.transform.position, groundPointSize, 0, Vector2.zero, 0, groundLayerMask);
        // Проверить, соприкосается ли он с землёй
        return hit.collider != null;
    }

    private void Attack()
    {
        string currentAnimState = animator.GetCurrentAnimatorClipInfo(0)[0].clip.name;
        if (Input.GetKeyDown(attackKey) && currentAnimState != "attack")
        {
            animator.SetTrigger("Attack");
        }
    }

}
