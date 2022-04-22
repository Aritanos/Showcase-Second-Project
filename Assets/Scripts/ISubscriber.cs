using System;
public interface ISubscriber
{
    public void Subcribe(Action action);
    public void UnSubscribe(Action action);
}

