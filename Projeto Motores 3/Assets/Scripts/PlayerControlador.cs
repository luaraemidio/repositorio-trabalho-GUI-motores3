using UnityEngine;

public class PlayerControlador : MonoBehaviour
{

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            PlayerOM.CollectCoin();
            Destroy(other.gameObject);
        }
    }
}