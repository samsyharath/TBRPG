using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimation : MonoBehaviour
{
    [Header("Dependencies")]
    public Animator animator;
    public SpriteRenderer spriteRenderer;

    // public void OnMovement(InputAction.CallbackContext value)
    // {
    //     float movementInput = value.ReadValue<Vector2>().magnitude;

    //     if (movementInput > 0f)
    //     {
    //         animator.SetBool("IsRunning", true);
    //     }
    //     else 
    //     {
    //         animator.SetBool("IsRunning", false);
    //     }

    //     // animator.SetBool("IsRunning", movementInput != Vector2.zero);
    // }
    public void OnMovement2(InputAction.CallbackContext value)
    {
        Vector2 movementInput = value.ReadValue<Vector2>();

        if (movementInput.y > 0f) // Moving up
        {
            animator.SetBool("IsGoingUp", true);
        }

        else if (movementInput.y < 0f) // Moving down
        {
            animator.SetBool("IsGoingDown", true);
        }
        else
        {
            animator.SetBool("IsGoingDown", false);
            animator.SetBool("IsGoingUp", false);
        }
        if (movementInput.x < 0f ) // Moving to the left
        {
            animator.SetBool("IsWalkingLeft", true);
        }
        else 
        {
            animator.SetBool("IsWalkingLeft", false);
        }
        
        if (movementInput.x > 0f ) // Moving to the right
        {
            animator.SetBool("IsWalkingRight", true);
        }
        else 
        {
            animator.SetBool("IsWalkingRight", false);       
        }

        
    }
    
}
