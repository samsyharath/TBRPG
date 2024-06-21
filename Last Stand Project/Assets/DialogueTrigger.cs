using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

	public Dialogue dialogue;

	void OnTriggerEnter(Collider other)
	{
		FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
	}
}