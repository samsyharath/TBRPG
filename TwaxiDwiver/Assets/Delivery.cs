using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
   bool hasPackage;
   [SerializeField] float destroyDelay = 0.5f;
   [SerializeField] Color32 hasPackageColor = new Color32 (1, 1, 1, 1);
   [SerializeField] Color32 noPackageColor = new Color32 (1, 1, 1, 1);
   SpriteRenderer spriteRenderer;

   void Start()
   {
      spriteRenderer = GetComponent<SpriteRenderer>();
   }
   void OnCollisionEnter2D(Collision2D other) 
   {
    Debug.Log("Oops!");
   }

   void OnTriggerEnter2D(Collider2D other)
   {
    if (other.tag == "Package" && !hasPackage)
    {
      hasPackage = true;
      Debug.Log("Package picked up");
      Destroy(other.gameObject, destroyDelay);
      spriteRenderer.color = hasPackageColor;
    }
    if (other.tag == "Customer" && hasPackage)
    {
      Debug.Log("Package delivered!");
      hasPackage = false;
      spriteRenderer.color = noPackageColor;
    }
   }
}
