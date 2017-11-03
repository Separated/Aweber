using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChracterController : MonoBehaviour
{
    public Slider passionBarSlider;
    public Text youWinText;
    public float moveSpeed;
    public float jumpSpeed;
    public float gravity;

    CharacterController cc;

    private Vector3 moveDirection = Vector3.zero;

    private bool jump;

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        moveDirection = transform.TransformDirection(moveDirection);


        Vector3 right = Input.GetAxis("Horizontal") * transform.TransformDirection(Vector3.right) * moveSpeed;

        cc.Move(right * Time.deltaTime);
        cc.SimpleMove(Physics.gravity * Time.deltaTime);

        if (controller.isGrounded == true && Input.GetButtonDown("Jump"))
        {
            moveDirection.y = jumpSpeed;
            
        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            passionBarSlider.value += .25f;

        }

        if (other.gameObject.CompareTag("Pick Up Light"))
        {
            other.gameObject.SetActive(false);
        }
    }
}