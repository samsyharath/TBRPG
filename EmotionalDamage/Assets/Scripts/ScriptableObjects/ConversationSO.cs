using UnityEngine;
using Ink.Runtime;

[System.Serializable]
public class Sentences
{
    public CharacterSO character;

    [SerializeField] public TextAsset inkJSON;
}

[CreateAssetMenu(fileName = "NewConversation", menuName = "Scriptable Objects/Conversation/Conversation")]
public class ConversationSO : ScriptableObject
{
    public CharacterSO speaker;
    public TextAsset inkJSON;
}