using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZombieFighter.Input
{
    [CreateAssetMenu(menuName = "ZombieFight/Input/Input ScriptableObject")]
    public class InputScriptableObject : ScriptableObject
    {
        public float Horizontal;
        public float Vertical;
        public bool Jump;
    }
}