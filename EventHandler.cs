using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventHandler : MonoBehaviour
{
	private void Start()
	{
		Event.AddListener(Handler);
		Event.Invoke();

		StringAction += HandlerToo;
		StringAction("Words");
	}


	public UnityEvent Event;
	public UnityAction<string> StringAction;

	public void Handler()
	{
		print("Something");
	}

	public void HandlerToo(string _s)
	{
		print(_s);
	}

}
