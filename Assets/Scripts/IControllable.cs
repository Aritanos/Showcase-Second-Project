namespace TestProject
{
    public interface IControllable
    {
        public void StartMoving();
        public void MoveSideways(float delta);
        public void StopMoving();
    }
}
