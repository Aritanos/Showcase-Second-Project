using UnityEngine;

namespace TestProject.Levels
{
    [CreateAssetMenu(fileName = "LevelsContainer", menuName = "Containers/LevelsContainer", order = 1)]
    public class LevelsContainer : ScriptableObject
    {
        [SerializeField] private Level[] _levelsList;

        public Level GetLevel(int levelIndex)
        {
            if (levelIndex >= _levelsList.Length)
                return _levelsList[_levelsList.Length];
            else
                return _levelsList[levelIndex];
        }
    }
}
