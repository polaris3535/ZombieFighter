using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using ZombieFighter.Input;

namespace ZombieFighter.Movement
{
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float playerMovementSpeed;
    [SerializeField] private float playerJumpSpeed;
    [SerializeField]private InputScriptableObject _inputScriptableObject;
    [SerializeField] private Rigidbody _rigidbody;
    void Update()
    {
        _rigidbody.position=new Vector3(_rigidbody.position.x+_inputScriptableObject.Horizontal*playerMovementSpeed,_rigidbody.position.y,_rigidbody.position.z +
            _inputScriptableObject.Vertical*playerMovementSpeed);
        if(_inputScriptableObject.Jump)
            _rigidbody.AddForce(Vector3.up*playerJumpSpeed);
    }
}
}
