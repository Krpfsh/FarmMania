using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerWASD : MonoBehaviour
{
    public static float speed=400;
    [SerializeField] private string inputNameHorizontal;
    [SerializeField] private string inputNameVertical;
    private Animator _animatorPlayer;
    private Rigidbody rb;
    Vector3 _directionVector;

    private float inputHorizontal;
    private float inputVertical;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        _animatorPlayer = GetComponent<Animator>();
        transform.Rotate(0, 180, 0);
    }

    private void Update()
    {
        inputHorizontal = Input.GetAxisRaw(inputNameHorizontal);
        inputVertical = Input.GetAxisRaw(inputNameVertical);
        if(Input.GetKey("w")|| Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
        {
            _animatorPlayer.SetBool("Run", true);
        }
        else
        {
            _animatorPlayer.SetBool("Run", false);
        }
        _directionVector = new Vector3(inputHorizontal * speed * Time.fixedDeltaTime, rb.velocity.y, inputVertical * speed * Time.fixedDeltaTime);
        if(_directionVector.magnitude == 0) { return; } // Идёт после определения _directionVector;
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(_directionVector),Time.deltaTime*10);
    }


    private void FixedUpdate()
    {
        rb.velocity = _directionVector;
    }
}

