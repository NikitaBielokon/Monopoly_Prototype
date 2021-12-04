using UnityEngine;

public class Dice
{
    private const int MIN_VALUE = 1;
    private const int MAX_VALUE = 7;

    public int RolledValue { get; private set; }

    public int Roll() => RolledValue = Random.Range(MIN_VALUE, MAX_VALUE);
}