using TMPro;
using UnityEngine;

public class DiceRepresenter : MonoBehaviour
{
    public static string TEXT = "Dice: ";

    [SerializeField] private TextMeshProUGUI[] _diceValueText;

    private void OnEnable() => DiceRoller.OnDiceValuesUpdated += OnDiceValuesUpdated;

    private void OnDisable() => DiceRoller.OnDiceValuesUpdated -= OnDiceValuesUpdated;

    private void ShowDiceValue(int diceTextValueIndex, int diceValue) => _diceValueText[diceTextValueIndex].text = TEXT + diceValue;

    private void OnDiceValuesUpdated(int[] diceValues)
    {
        for(int i = 0; i < diceValues.Length; i++)
        {
            ShowDiceValue(i, diceValues[i]);
        }
    }
}