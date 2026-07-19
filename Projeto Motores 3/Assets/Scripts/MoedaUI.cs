using UnityEngine;
using TMPro;

public class MoedaUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinText;
    private int coinCount = 0;

    private void OnEnable()
    {
        PlayerOM.OnCoinCollected += UpdateCoinCount;
    }

    private void OnDisable()
    {
        PlayerOM.OnCoinCollected -= UpdateCoinCount;
    }

    private void UpdateCoinCount()
    {
        coinCount++;
        if (coinText != null)
            coinText.text = $"Moedas: {coinCount}";
    }
}