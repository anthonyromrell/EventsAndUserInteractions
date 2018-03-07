using UnityEngine;

[CreateAssetMenu]
public class PlayAction : NewAction {

	public override event MyNewDelegate MyNewEvent;

	public override void Run()
	{
		//MyNewEvent += Caller;
		Debug.Log("what");
		if (MyNewEvent != null)
		{
			MyNewEvent.Invoke();
		}
		else
		{
			Debug.Log("Null");
		}
	}

	protected override void Awake()
	{
		Debug.Log("run");
		MyNewEvent += Caller;
	}

	private void Caller()
	{
		Debug.Log("Rats");
	}
}
