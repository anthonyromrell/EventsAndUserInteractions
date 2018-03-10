using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "TextActionHandler")]
public class TextActionHandler : GameActionHandler
{
	public string ObjectText;
	public UnityEvent Event;

	protected override void Respond (object obj)
	{
		ObjectText = obj as string;
		Event.Invoke();
	}
}