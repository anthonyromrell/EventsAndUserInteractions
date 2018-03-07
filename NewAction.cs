using UnityEngine;

public abstract class NewAction : ScriptableObject {

	public delegate void MyNewDelegate();

	public abstract event MyNewDelegate MyNewEvent;

	public abstract void Run();

	protected virtual void Awake()
	{
		//throw new System.NotImplementedException();
	}
}
