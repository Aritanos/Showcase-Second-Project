using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private Transform _playerStartingPosition;
    public Transform PlayerStartingPosition { get { return _playerStartingPosition; } private set { } }
}
