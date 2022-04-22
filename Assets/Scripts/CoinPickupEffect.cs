using UnityEngine;

public class CoinPickupEffect : MonoBehaviour
{
    public void Awake()
    {
        Destroy(gameObject, 4);
    }
}


