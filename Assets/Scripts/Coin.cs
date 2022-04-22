using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : ScoreUpdater
{
    
    [SerializeField] private int _coinScore;
    [SerializeField] private CoinPickupEffect _puckupEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<IControllable>()!=null)
        {
            InvokeScoreUpdate(_coinScore);
            DestroyObject();
            Instantiate(_puckupEffect, transform.position, Quaternion.identity);
        }
    }

    private void DestroyObject()
    {
        GetComponent<Collider>().enabled = false;
        Destroy(gameObject);
    }
}

