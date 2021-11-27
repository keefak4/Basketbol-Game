using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBullet : MonoBehaviour
{
    [SerializeField] private GameObject Ball;
    [SerializeField] private float speedBall;
    private void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject ballAttacl = Instantiate(Ball, transform.position, Quaternion.identity);
            ballAttacl.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * speedBall);
        }
    }
}
