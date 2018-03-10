using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameAction : ScriptableObject
{
	public UnityAction<object> Call;
	public UnityAction CallNoArgs;
	
	public void ActionCall()
	{
		CallNoArgs();
	}
	
	
	//Overloading
	public void ActionCall(Transform obj)
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
}