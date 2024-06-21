using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{

	public TextMeshProUGUI nameText;
	public TextMeshProUGUI dialogueText;
	public Animator animator;

	public Queue<string> sentences;

	// Use this for initialization
	void Start()
	{
		sentences = new Queue<string>();
	}

	void Update()
	{if (Input.GetKeyDown(KeyCode.F))

            DisplayNextSentence();
	}

	public void StartDialogue(Dialogue dialogue)
	{
		sentences.Clear();
		
		nameText.text = dialogue.name;

		animator.SetBool("IsOpen", true);
		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}
		DisplayNextSentence();
	}

	private void DisplayNextSentence()
	{
		if (sentences.Count == 0)
		{
			EndDialogue();
			return;
		}

		string sentence = sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));
	}

	IEnumerator TypeSentence(string sentence)
	{
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			dialogueText.text += letter;
			yield return null;
		}
	}

	void EndDialogue()
	{
		animator.SetBool("IsOpen", false);
		Time.timeScale = 1f;
	}

}