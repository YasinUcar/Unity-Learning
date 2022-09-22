using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    Vector2 moveInput;
    Rigidbody2D rigidbody;
    [SerializeField] float runSpeed = 5;
    [SerializeField] float jumpSpeed = 5;
    [SerializeField] float climpSpeed = 5;
    float gravityScaleAtStart;
    CapsuleCollider2D BodyCollider2D;
    BoxCollider2D myFeetCollider;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        BodyCollider2D = GetComponent<CapsuleCollider2D>();
        gravityScaleAtStart = rigidbody.gravityScale;
        myFeetCollider = GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        Run();
        FlipSprite();
        ClimbLadder();
    }
    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();

    }
    void OnJump(InputValue value)
    {
        if (!myFeetCollider.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
            return;
        }
        if (value.isPressed)
        {
            rigidbody.velocity += new Vector2(0f, jumpSpeed);
        }
    }


    void Run()
    {
        Vector2 playerVelocity = new Vector2(moveInput.x * runSpeed, rigidbody.velocity.y);
        rigidbody.velocity = playerVelocity;
    }
    void FlipSprite()
    {
        //Abs: Verilen sayının mutlak değerini elde etmemizi sağlar -10 verirsen 10 döner. Burada bizim için önemli olan hareket edip etmediğimiz
        bool playerHasHorizontalSpeed = Mathf.Abs(rigidbody.velocity.x) > Mathf.Epsilon;
        if (playerHasHorizontalSpeed)
        {
            //Sign: Verilen değerin negatif veya pozitiflik durumunu elde etmemizi sağlar. Eğer değer 0 veya pozitif değer ise 1, negatif ise -1 döndürür.
            //Sprite x ekseninde -1'den +1'e değişiklik göstereceği için sign kullanmaktayız.
            transform.localScale = new Vector2(Mathf.Sign(rigidbody.velocity.x), 1f);//y sabit kalabilir
        }
    }
    void ClimbLadder()
    {
        if (!myFeetCollider.IsTouchingLayers(LayerMask.GetMask("Ladder")))
        {
            rigidbody.gravityScale = gravityScaleAtStart;
            return;
        }
        Vector2 climpVelocity = new Vector2(rigidbody.velocity.x, moveInput.y * climpSpeed);
        rigidbody.velocity = climpVelocity;
        rigidbody.gravityScale = 0f;
    }
}
