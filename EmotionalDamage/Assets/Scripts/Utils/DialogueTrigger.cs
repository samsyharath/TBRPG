using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;
using Ink.Runtime;
using UnityEngine.InputSystem;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Conversation")]
    [SerializeField] public TextAsset inkJSON;

    [Header("Broadcasting events")]
    public ConversationSOGameEvent conversationRequestEvent;
    
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    private bool playerInRange;

    private void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);
    }

    private void Update()
    {
        if (playerInRange)
        {
            visualCue.SetActive(true);
            if(Keyboard.current.eKey.isPressed)
            {
                TriggerConversation();
            }
            else if(Keyboard.current.fKey.isPressed)
            {
                DialogueManager.GetInstance().ContinueStory();
            }
        }
        else
        {
            visualCue.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {playerInRange = true;}
    }

    private void OnTriggerExit2D(Collider2D collider)
        {
            if (collider.gameObject.tag == "Player")
            {playerInRange = false;}
        }

     public void TriggerConversation()
     {
        DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
     }

}
