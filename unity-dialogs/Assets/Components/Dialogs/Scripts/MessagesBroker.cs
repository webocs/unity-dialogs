using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wbx.Dialogs
{
    public class MessagesBroker : MonoBehaviour
    {
        private static MessagesBroker instance = null;
        private MessagesQueue messagesQueue;
        private List<Talker> registeredTalkers;
        [SerializeField] private float defaultMessageFeedTime;
        [SerializeField] private Toast toast;
        private void Awake()
        {
            messagesQueue = new MessagesQueue();
            if (instance == null)
                instance = this;
            else if (instance != this) Destroy(gameObject);
            //Sets this to not be destroyed when reloading scene
            DontDestroyOnLoad(gameObject);
        }

        public void AddNewMessage(Talker talker, string message)
        {
            if (talker.showTalkerName)
            {
                messagesQueue.EnqueueMessage(new Message() { sender = talker.talkerName, message = message });
            }
            else
            {
                Message m = new Message() { sender = talker.talkerName, message = message };
                m.ConfigureTemplate("{1}");
                messagesQueue.EnqueueMessage(m);
            }
        }

        public void Update()
        {
            while (messagesQueue.HasNext())
            {
                Debug.Log(messagesQueue.GetNextMessage());
            }
        }

    }
}
