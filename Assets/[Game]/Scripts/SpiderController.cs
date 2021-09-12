using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Rigidbody2D))]
public class SpiderController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpPower;
    [SerializeField] Transform head;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //StartHeadAnimation();
        HandleHeadRotation();
    }

    private void FixedUpdate()
    {
        if (Mathf.Abs(rb.velocity.x) < speed)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(Vector2.right * 50f);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(Vector2.left * 50f);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            }
        }
    }

    //private void StartHeadAnimation()
    //{
    //    float duration = 1f;

    //    head.DOLocalRotate(Vector3.forward * -15f, duration / 2f)
    //        .OnComplete(() => {
    //            head.DOLocalRotate(Vector3.forward * 30f, duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    //        });
    //}

    private void HandleHeadRotation()
    {
        float maxAngle = 15f;

    }
}
