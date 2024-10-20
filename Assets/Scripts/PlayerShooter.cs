using UnityEngine;

[RequireComponent(typeof(PlayerControlller))]
public class PlayerShooter : MonoBehaviour
{
   private PlayerControlller controller;
   private Weapon[] weapons;

   private void Start() {
      controller = GetComponent<PlayerControlller>();
      weapons = GetComponentsInChildren<Weapon>();
   }

   private void Update() {
      Shot();
   }

   private void Shot() {
      //if (Input.GetKeyDown(KeyCode.Space)) {
      if (controller.InputHandler.GetFire1Button()) {
         foreach (Weapon weapon in weapons) {
            weapon.FireWhenReady();
         }
      }
   }
}