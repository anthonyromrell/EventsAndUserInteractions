using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class GameActionEvent : UnityEvent<object>
{

    [SerializeField] public UnityEvent<object> Event;

}
