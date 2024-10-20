using UnityEngine;

public class PlayerControlller : MonoBehaviour
{
   public InputHandler InputHandler { get; private set; }

   private void Start() {
      InputHandler = GetComponent<InputHandler>();
   }
}