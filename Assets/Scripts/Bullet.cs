using UnityEngine;

public class Bullet : MonoBehaviour
{
   [SerializeField]
   private float speed = 10f;

   [SerializeField]
   private float maxLimitX = 3;

   [SerializeField]
   private float minLimitX = -3;

   [SerializeField]
   private float maxLimitY = 3;

   [SerializeField]
   private float minLimitY = -3;

   private void Update() {
      transform.Translate(Vector2.up * speed * Time.deltaTime);

      if (
            transform.position.x >= maxLimitX ||
            transform.position.x <= minLimitX ||
            transform.position.y <= minLimitY ||
            transform.position.y >= maxLimitY
         ) {
         Destroy(gameObject);
      }
   }
}