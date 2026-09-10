using TMPro;  
using UnityEngine;
using UnityEngine.UI;
public class groundScript : MonoBehaviour
{
    public GameObject ground;
    public GameObject player;
    public Image loseImage;
    public TMP_Text losetext;
    public GameObject restart;
    private void OnCollisionEnter(Collision collision)
    {
        PlayerScript playerscript = GetComponent<PlayerScript>();

        if (collision.gameObject.GetComponent<PlayerScript>())
        {
            Destroy(player);
            Debug.Log("die");
            loseImage.enabled = true;
            losetext.enabled = true;
            restart.SetActive(true);
            losetext.text = "you lose";
        }
        else
        {
            loseImage.enabled = false;
            losetext.enabled = false;
            restart.SetActive(false);
        }
    }
}
