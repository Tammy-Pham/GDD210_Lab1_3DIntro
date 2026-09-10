using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public GameObject player;
    public GameObject coin;

    private void OnCollisionEnter(Collision collision)
    {
        PlayerScript playerscript = collision.gameObject.GetComponent<PlayerScript>();
        if(collision.gameObject.GetComponent<PlayerScript>())
        {
            Destroy(coin);
            playerscript.amountCoin += 1;
        }
    }
}
