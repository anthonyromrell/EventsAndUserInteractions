using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "TextActionHandler", menuName = "Actions/Game Action")]
public class TextActionHandler : GameActionHandler
{
	public UnityEvent<string> Event;

	protected override void Respond (object obj)
	{
		Event.Invoke((string) obj);
	}
}