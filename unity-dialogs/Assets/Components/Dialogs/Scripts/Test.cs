using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wbx.Dialogs
{
    public class Test : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            MessagesQueue messagesQueue = new MessagesQueue();
            Message m1 = new Message { message = "Hello from message 1", sender = "Sender 1" };
            Message m2 = new Message { message = "I'll never make it..", sender = "Sender 2" };
            Message m3 = new Message { message = "Message 2 was deleted, so here's message 3", sender = "Sender 3" };
            Message m4 = new Message { message = "Message 1 was supposes to be here, but it was overriten by me, MESSAGE 4!", sender = "Sender 4" };
            Message m5 = new Message { message = "Stop peeking!!, No sender here, I dislike your format!", sender = "Sender 5" };
            m5.ConfigureTemplate("{1}");


            messagesQueue.EnqueueMessage(m1);
            messagesQueue.EnqueueMessage(m2);
            messagesQueue.EnqueueMessage(m3);
            messagesQueue.OverrideMessage(0,m4);
            messagesQueue.DeleteMessage(1);

            while (messagesQueue.HasNext())
            {
                Debug.Log(messagesQueue.GetNextMessage().ToString());
            }
            messagesQueue.EnqueueMessage(m5);
            Debug.Log("Peeking into queue....");
            Debug.Log("======================");
            Debug.Log(messagesQueue.PeekMessage(0));
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
