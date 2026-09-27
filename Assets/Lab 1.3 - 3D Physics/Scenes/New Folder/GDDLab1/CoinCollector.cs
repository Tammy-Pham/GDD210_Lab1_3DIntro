using UnityEngine;

public class CoinCollector : MonoBehaviour
{

    public void Collect()
    {
        Debug.Log("Collected");
        Destroy(gameObject);
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        PlayerScript playerscript = collision.gameObject.GetComponent<PlayerScript>();
        if(collision.gameObject.GetComponent<PlayerScript>())
        {
            Destroy(coin);
            playerscript.amountCoin += 1;
        }
    }*/
}
