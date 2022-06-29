using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


namespace Scripts
{
    public class HeroInputReader : MonoBehaviour
{
    [SerializeField] private Hero _hero;

  
    public void OnHorizontalMovement(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<float>(); 
        _hero.SetDirectionHor(direction);
    }

      public void OnVerticalMovement(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<float>(); 
        _hero.SetDirectionVert(direction);
    }


    public void OnSaySmth (InputAction.CallbackContext context)
    {
        if(context.canceled)
        {
            _hero.SaySmth(); 
        }
    }

} 

}
  
