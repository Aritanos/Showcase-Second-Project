using UnityEngine;

namespace TestProject.Levels
{
    public class Level : MonoBehaviour
    {
        [SerializeField] private Transform _playerStartingPosition;
        public Transform PlayerStartingPosition { get { return _playerStartingPosition; } private set { } }
    }
}
