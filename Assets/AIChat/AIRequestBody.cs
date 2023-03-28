﻿using System.Collections.Generic;
using MMORPG.UI.AIChat;

[System.Serializable]
public class AIRequestBody
{
    public string model = "gpt-3.5-turbo";
    public List<AIMessage> messages;
    public bool stream = true;
}