using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZombieFighter.Input;

public class InputManager : MonoBehaviour
{
    [SerializeField] private  InputScriptableObject _inputScriptableObject;
    void Update()
    {
        _inputScriptableObject.Horizontal = Input.GetAxis("Horizontal");
        _inputScriptableObject.Vertical = Input.GetAxis("Vertical");
        _inputScriptableObject.Jump = Input.GetKeyDown(KeyCode.Space);
    }
}
