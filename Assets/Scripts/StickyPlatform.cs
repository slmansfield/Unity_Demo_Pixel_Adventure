using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
   private void OnCollisonEnter2D(Collision2D collision)
   {
      if (collision.gameObject.tag == "Player")
      {
         collision.gameObject.transform.SetParent(transform);
      }
   }
   
   private void OnCollisonExit2D(Collision2D collision)
   {
      if (collision.gameObject.tag == "Player")
      {
         collision.gameObject.transform.SetParent(null);
      }
   }
}