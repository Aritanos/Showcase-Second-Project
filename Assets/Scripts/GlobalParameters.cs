public struct GlobalParameters
{
    public GlobalParameters(bool isMoving, bool isMenuEnabled, bool isNewLevel)
    {
        IsMoving = isMoving;
        IsMenuEnabled = isMenuEnabled;
        IsNewLevel = isNewLevel;
    }

    public readonly bool IsMoving;
    public readonly bool IsMenuEnabled;
    public readonly bool IsNewLevel;
}



