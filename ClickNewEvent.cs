using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickNewEvent : MonoBehaviour
{


	public NewAction MyAction;

	private void OnMouseUp()
	{
		MyAction.Run();
	}
}
