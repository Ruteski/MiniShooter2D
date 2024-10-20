using UnityEngine;

public class Weapon : MonoBehaviour
{
   [SerializeField]
   private Bullet bulletPrefab;

   [SerializeField]
   private float cooldownTime = 1f;

   private float timeToShoot;

   private void Start() {
      timeToShoot = cooldownTime;
   }

   private void Update() {
      timeToShoot += Time.deltaTime;
   }

   public void FireWhenReady() {
      //GameObject bullet = Instantiate(Resources.Load("Prefabs/Bullet") as GameObject);

      if (timeToShoot > cooldownTime) {
         Instantiate(bulletPrefab, transform.position, transform.rotation);
         timeToShoot = 0;
      }
   }
}