using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float Gravity = -9.8f;
    public CharacterController PlayerControler;
    public float MoveSpeed;
    public float JumpSpeed;

    public float verticalSpeed;

    private void Start()
    {
        Application.targetFrameRate = 15;
    }
    private void Update()
    {
        Vector3 move = Vector3.zero;

        //this applies the walking motion for the player 
        float forwardmove = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
        float sidemove = Input.GetAxis("Horizontal") * MoveSpeed * Time.deltaTime;
        move += (transform.forward * forwardmove) + (transform.right * sidemove);

        if (PlayerControler.isGrounded)
        {
            verticalSpeed = 0f;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalSpeed = JumpSpeed;
            }
        }

        verticalSpeed += Gravity * Time.deltaTime;
        move += (transform.up * verticalSpeed * Time.deltaTime);

        PlayerControler.Move(move);
    }
   


}
