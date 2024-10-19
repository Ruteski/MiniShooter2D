using UnityEngine;

public class Weapon : MonoBehaviour
{
   [SerializeField]
   private Bullet bulletPrefab;

   public void Fire() {
      //GameObject bullet = Instantiate(Resources.Load("Prefabs/Bullet") as GameObject);
      Instantiate(bulletPrefab, transform.position, transform.rotation);
   }
}