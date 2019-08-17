using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wbx.Dialogs
{
    public class MessagesQueue
    {
        List<Message> messages;
        public MessagesQueue()
        {
            messages = new List<Message>();
        }

        public bool HasNext()
        {
            return messages.Count > 0;
        }
        public void EnqueueMessage(Message message) {
            AddToQueue(message, messages.Count);
        }
        public void EnqueueMessage(Message message, bool overrideTop) {
            if (overrideTop)
                AddToQueue(message,0);
            else EnqueueMessage(message);
        }

        public void OverrideMessage(int position, Message message) {
            messages.RemoveAt(position);
            AddToQueue(message, position);
        }
        public Message PeekMessage(int position) {
            return messages[position];
        }
        public Message GetNextMessage(){
            Message retMessage = null;
            if (messages.Count > 0) {
                retMessage = messages[0];
                messages.RemoveAt(0);
            }
            return retMessage;
        }
        public void DeleteMessage(int position) {
            messages.RemoveAt(position);
        }


        private void AddToQueue(Message message, int position)
        {
            messages.Insert(position, message);
        }
    }
   
}
