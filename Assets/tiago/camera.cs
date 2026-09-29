
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class camera : MonoBehaviour
{
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundDist;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private int totalJump;
    [SerializeField] private Animator anim;
    [SerializeField] private Transform look;
    [SerializeField] private Transform cameraTarget;
    [SerializeField] private float cameraSpeed;
    private int jumpLes;
    private bool canJump;
    private bool isGroundCheck;

    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;
    private float inputDirection;
    private bool isDirectionRight = true;
    private Rigidbody2D rb2d;





    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
