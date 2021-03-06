using UnityEngine;

namespace TestProject
{
    public class Finish : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<IControllable>() != null)
            {
                TriggerGlobalGameEvent(GlobalGameEvent.Finish);
            }
        }

        private void TriggerGlobalGameEvent(GlobalGameEvent gameEvent)
        {
            GetComponent<Collider>().enabled = false;
            GameStateHandler.TriggerEvent(gameEvent);
        }
    }
}
