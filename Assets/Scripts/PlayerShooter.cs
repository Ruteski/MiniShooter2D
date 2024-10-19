using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
   private Weapon[] weapons;

   private void Start() {
      weapons = GetComponentsInChildren<Weapon>();
   }

   private void Update() {
      Shot();
   }

   private void Shot() {
      if (Input.GetButton("Fire1")) {
         foreach (Weapon weapon in weapons) {
            weapon.Fire();
         }
      }
   }
}