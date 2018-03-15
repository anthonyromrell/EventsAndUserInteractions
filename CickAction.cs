using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CickAction : MonoBehaviour
{

	public GameAction GameAction;

	private void OnMouseDown()
	{
		GameAction.Call(transform);
	}
}
