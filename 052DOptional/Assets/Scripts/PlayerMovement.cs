using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    Vector2 moveInput;
    Rigidbody2D rigidbody;
    [SerializeField] float runSpeed = 5;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        print(rigidbody.velocity.x);
        Run();
        FlipSprite();
    }
    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();

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
}
