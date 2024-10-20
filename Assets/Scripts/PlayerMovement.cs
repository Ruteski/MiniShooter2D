using UnityEngine;

[RequireComponent(typeof(PlayerControlller))]
public class PlayerMovement : MonoBehaviour
{
   [SerializeField]
   private float speed = 5f;

   [SerializeField]
   private float horizontalPositionMaxLimit = 3f;

   [SerializeField]
   private float horizontalPositionMinLimit = -3f;

   [SerializeField]
   private float verticalPositionMaxLimit = 3f;

   [SerializeField]
   private float verticalPositionMinLimit = -3f;

   private PlayerControlller controlller;

   private void Start() {
      controlller = GetComponent<PlayerControlller>();
   }

   private void Update() {
      Move();
      LimitMovement();
   }

   private void Move() {
      // float horizontalInput = Input.GetAxis("Horizontal");
      // float verticalInput = Input.GetAxis("Vertical");
      float horizontalInput = controlller.InputHandler.GetHorizontalAxis();
      float verticalInput = controlller.InputHandler.GetVerticalAxis();

      Vector3 direction = new Vector2(horizontalInput, verticalInput).normalized;
      transform.position += direction * speed * Time.deltaTime;
   }

   private void LimitMovement() {
#region Limites horizontais

      if (transform.position.x >= horizontalPositionMaxLimit) {
         transform.position = new Vector2(horizontalPositionMaxLimit, transform.position.y);
      }

      if (transform.position.x <= horizontalPositionMinLimit) {
         transform.position = new Vector2(horizontalPositionMinLimit, transform.position.y);
      }

#endregion

#region Limites verticais

      if (transform.position.y >= verticalPositionMaxLimit) {
         transform.position = new Vector2(transform.position.x, verticalPositionMaxLimit);
      }

      if (transform.position.y <= verticalPositionMinLimit) {
         transform.position = new Vector2(transform.position.x, verticalPositionMinLimit);
      }

#endregion
   }
}