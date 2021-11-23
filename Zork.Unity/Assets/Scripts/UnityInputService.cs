using System;
using UnityEngine;
using UnityEngine.UI;
using Zork;

public class UnityInputService : MonoBehaviour, IInputService
{
    public event EventHandler<string> InputRecieved;

    internal void ProcessInput()
    {
        if (string.IsNullOrWhiteSpace(InputField.text) == false)
        {
            InputRecieved?.Invoke(this, InputField.text);
        }

        InputField.text = string.Empty;
    }

    [SerializeField]
    private InputField InputField;
}
