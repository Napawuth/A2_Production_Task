using UnityEngine;

public class ChatTrigger : MonoBehaviour
{
    [SerializeField] private GameObject chatBubble; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            chatBubble.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // Hide it when the player walks away
        if (collision.CompareTag("Player"))
        {
            chatBubble.SetActive(false);
        }
    }
}