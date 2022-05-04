using UnityEngine;
using System;

namespace TestProject.InputSystem
{
    public abstract class InputReceiver : MonoBehaviour
    {
        public abstract event Action<Vector3> PointerDown;
        public abstract event Action<Vector3> PointerHold;
        public abstract event Action PointerUp;
    }
}



