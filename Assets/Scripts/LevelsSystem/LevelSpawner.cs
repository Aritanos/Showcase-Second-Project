using UnityEngine;

namespace TestProject.Levels
{
    public class LevelSpawner : MonoBehaviour
    {
        [SerializeField] private LevelsContainer _levelsContainer;
        [SerializeField] private Transform _playerTransform;
        [SerializeField] private Transform _parentObject;

        public Level _currentLevel;

        private void Awake()
        {
            GameStateHandler.Subscribe(GlobalGameEvent.Start, SpawnNewLevel);
        }

        public void SpawnNewLevel()
        {
            if (_currentLevel != null)
                Destroy(_currentLevel.gameObject);
            _currentLevel = Instantiate(_levelsContainer.GetLevel(0), _parentObject);
            _playerTransform.position = _currentLevel.PlayerStartingPosition.position;
        }
    }
}
