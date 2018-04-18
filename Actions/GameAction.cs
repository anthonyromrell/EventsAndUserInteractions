﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Actions/Game Action")]
public class GameAction : ScriptableObject
{
	public UnityAction<object> Call;
	public UnityAction CallNoArgs;
	
	//Overloading
	public void ActionCall()
	{
		CallNoArgs();
	}
	
	public void ActionCall(Transform obj)
	{
		Call(obj);
	}
	
	public void ActionCall(List<Transform> obj)
	{
		Call(obj);
	}
	
	public void ActionCall(int obj)
	{
		Call(obj);
	}
	
	public void ActionCall(string obj)
	{
		Call(obj);
	}

	public void ActionCall(Text obj)
	{
		var temp = obj.text;
		Call(temp);
	}
}