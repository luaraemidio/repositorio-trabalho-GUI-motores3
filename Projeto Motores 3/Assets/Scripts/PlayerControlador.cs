using UnityEngine;

public class PlayerControlador : MonoBehaviour
{

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            PlayerOM.CollectCoin();
            Destroy(other.gameObject);
        }
    }
}