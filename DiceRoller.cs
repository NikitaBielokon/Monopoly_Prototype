using System;
using UnityEngine;

public class DiceRoller : MonoBehaviour
{
    public static event Action<int[]> OnDiceValuesUpdated;

    public int Value { get; private set; }
    private readonly Dice[] _dices = { new Dice(), new Dice() };

    public void Roll()
    {
        Value = 0;

        foreach(Dice dice in _dices)
        {
            Value += dice.Roll();
        }

        OnDiceValuesUpdated(GetDiceValue());
    }

    public bool WasDoubleRolled() => _dices[0].RolledValue == _dices[1].RolledValue;

    private int[] GetDiceValue() => new int[] { _dices[0].RolledValue, _dices[1].RolledValue };
}