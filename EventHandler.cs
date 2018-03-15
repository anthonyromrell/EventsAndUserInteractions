using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventHandler : MonoBehaviour
{

	public GameAction GameAction;
	public GameActionEvent GameActionEvent;

	private void Awake()
	{
		GameAction.Call += Repsond;
		GameActionEvent.AddListener(Work);
	}

	private void Repsond(object obj)
	{
		GameActionEvent.Invoke(obj);
	}
	
	public void Work(object obj)
	{
		print(obj as Transform);
	}
}
