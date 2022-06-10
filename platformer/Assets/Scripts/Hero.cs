using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class Hero : MonoBehaviour
{   
    private float _direction; 
    [SerializeField] private float _speed;

    public void SetDirection(float direction)
    {
      _direction = direction;
    }




    private void Update()
    {
      if (_direction != 0)
      {
        var delta = _direction * _speed * Time.deltaTime; 
        var newXPos = transform.position.x + delta; 
        transform.position = new Vector3(newXPos, transform.position.y, transform.position.z);

      }



    }


    public void SaySmth()
    {
      Debug.Log("Smth");
    }
}
}

