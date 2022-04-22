using UnityEngine;

namespace TestProject.CoinSystem
{
    public class CoinPickupEffect : MonoBehaviour
    {
        public void Awake()
        {
            Destroy(gameObject, 4);
        }
    }
}


