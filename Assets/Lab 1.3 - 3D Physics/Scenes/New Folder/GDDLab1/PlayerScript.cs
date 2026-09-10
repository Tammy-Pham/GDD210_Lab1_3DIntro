using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float MoveSpeed;
    [SerializeField] private Rigidbody Rb;
    public float amountCoin;
    public float JumpForce;
    private int jumps;
    private bool jump;
    public GameObject players;
    private float inputx;
    private float inputz;
    public Image winImage;
    public TMP_Text winningtext;
    public GameObject restart;

    // Update is called once per frame
    private void Update()
    {
        //movement
        float inputx = Input.GetAxis("Horizontal");
        float inputz = -Input.GetAxis("Vertical");


        if (Input.GetKey(KeyCode.Space) && jumps > 0)
        {
            jumps -= 1;
            jump = true;
            //helps the player stay upright(most of the time)
            players.transform.rotation = Quaternion.identity;
        }

        //controlbutton 
        transform.position += Vector3.forward * inputx * MoveSpeed * Time.deltaTime;
        transform.position += Vector3.right * inputz * MoveSpeed * Time.deltaTime;

        //have rotation follow based on the rotation 

        if(amountCoin == 7)
        {
            Debug.Log("you win");
            winImage.enabled = true;
            winningtext.enabled = true;
            winningtext.text = "you win";
            restart.SetActive(true);
            Rb.isKinematic = true;

        }
        else
        {
            winImage.enabled = false;
            winningtext.enabled = false;
            restart.SetActive(false);
        }
        
    }

    private void FixedUpdate()
    {
        if(jump == true)
        {
            Rb.linearVelocity = new Vector3(Rb.linearVelocity.x, JumpForce, Rb.linearVelocity.z);
            jump = false;
        }

        Rb.linearVelocity = (Vector3.right * inputx * MoveSpeed) + (Vector3.forward * inputz * MoveSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        jumps = 2;
    }
}
