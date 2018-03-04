using System.Collections;
using System.Collections.Generic;
using RoboRyanTron.Unite2017.Events;
using UnityEngine;


namespace AR.Events
{
    public class ClickEvent : MonoBehaviour
    {
        public GameEvent Event;

        private void OnMouseDown()
        {
            Event.Raise();
        }
    }

}

