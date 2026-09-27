using TMPro;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public float amountCoin;
    public Transform CamTransform;
    public float MouseSensitvity;
    private float camRotation = 0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float mouseInputY = Input.GetAxis("Mouse Y") * MouseSensitvity * Time.deltaTime;
        camRotation -= mouseInputY;
        camRotation = Mathf.Clamp(camRotation, -90f, 90f);
        CamTransform.localRotation = Quaternion.Euler(camRotation, 0f, 0f);

        float mouseInputx = Input.GetAxis("Mouse X") * MouseSensitvity * Time.deltaTime;
        transform.rotation = Quaternion.Euler(transform.eulerAngles + new Vector3(0f, mouseInputx));

        if (amountCoin == 8)
        {
            Debug.Log("you win");
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            RayCasting();
        }

       
    }

    private void RayCasting()
    {
        RaycastHit hit;
        if(Physics.Raycast(CamTransform.position, CamTransform.forward,out hit))
        {
            Debug.DrawLine(CamTransform.position + new Vector3(0f, -1f, 0f), hit.point, Color.green, 5f);
            CoinCollector hitCoin = hit.collider.gameObject.GetComponent<CoinCollector>();

            Debug.Log(hit.collider.gameObject.name);
            if (hitCoin != null)
            {
                Debug.Log("hit Coin!");
                hitCoin.Collect();
            }
            else
            {
                Debug.Log("not hit coin");
            }
        }
    }
}
