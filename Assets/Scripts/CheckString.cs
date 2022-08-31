using UnityEngine;


public class CheckString
{
    public static void CheckForNull(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            Debug.LogError("One or more value in XML Is Null Or Empty");
        }
    }
    public static void CheckForDigital(string value, out string editedValue)
    {
        foreach (char c in value)
        {
            if (c == '.')
            {
                value = value.Replace(".", ",");
            }

            if (!char.IsDigit(c) && c != '.' && c != ',' && c != '-' && c != '+')// возможные символы
            {
                Debug.LogError("One or more value in XML Is contains letter");
                break;
            }
        }
        editedValue = value;
    }
}
