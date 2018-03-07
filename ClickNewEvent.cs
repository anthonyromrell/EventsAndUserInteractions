using UnityEngine;

public class ClickNewEvent : MonoBehaviour
{


	public NewAction MyAction;

	private void OnMouseUp()
	{
		MyAction.Run();
	}
}
