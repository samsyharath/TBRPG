using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Textbehaviour : MonoBehaviour
{
    public TextMeshProUGUI myText;
    int textNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            textNumber++;
            myText.text = textNumber.ToString();
        }else if (Input.GetKeyDown(KeyCode.S)){
            myText.text = "S was pressed";
        }
    }
}
