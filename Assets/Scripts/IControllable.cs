using UnityEngine;

namespace TestProject
{
    public interface IControllable
    {
        public void StartMoving();
        public void MoveSideways(Vector3 position);
        public void StopMoving();
    }
}
