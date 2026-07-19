using UnityEngine;
using System;

public static class PlayerOM
{
    public static event Action OnCoinCollected;

    public static void CollectCoin()
    {
        OnCoinCollected?.Invoke();
    }

    
    public static void ClearListeners()
    {
        OnCoinCollected = null;
    }
}