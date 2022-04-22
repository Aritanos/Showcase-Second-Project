using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IControllable
{
    public void StartMoving();
    public void MoveSideways(float delta);
    public void StopMoving();
}
