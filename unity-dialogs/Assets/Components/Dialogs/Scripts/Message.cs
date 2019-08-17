using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Message
{
    public string sender { get; set; }
    public string message {get;set;}
    private string messageTemplate = "{0}:{1}";

  
    public void ConfigureTemplate(string messageTemplate)
    {
        this.messageTemplate = messageTemplate;
    }
    public override string ToString()
    {
        return string.Format(messageTemplate, sender, message);
    }
}
