using UnityEngine;

public class Frame : MonoBehaviour
{
    [SerializeField] private GameObject messagePrefab;

    public Message AddChatMessage(string content,string role)
    {
        var newMessage = GameObject.Instantiate(messagePrefab, gameObject.transform);
        
        var message = newMessage.GetComponent<Message>();
        message.SetContent(content);
        message.SetAvatar(role);
        return newMessage.GetComponent<Message>();
    }
}