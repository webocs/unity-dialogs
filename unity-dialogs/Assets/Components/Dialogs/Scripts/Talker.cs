using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wbx.Dialogs
{
    public class Talker : MonoBehaviour
    {
        MessagesBroker messagesBroker;
        [SerializeField] public string talkerName;
        [SerializeField] public Sprite talkerPortrait;
        [SerializeField] public bool showTalkerName;
        [SerializeField] public bool showTalkerPortrait;
        [SerializeField] public Font customTalkerFont;
        private void Awake()
        {
            messagesBroker = FindObjectOfType<MessagesBroker>();
            if (messagesBroker == null) throw new System.Exception(string.Format("Missing Messages broker, Talker {0} requires a message broker to talk.", name));           
        }

        public void Say(string message) {
            messagesBroker.AddNewMessage(this,message);
        }

    }
}
