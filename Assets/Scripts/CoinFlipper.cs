using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFlipper : MonoBehaviour
{
    [SerializeField] private float _speed = 0;

    private void FixedUpdate()
    {
        transform.Rotate(new Vector3(1.5f, 1, 1.2f) * _speed, Space.Self);
    }
}
