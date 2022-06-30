using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class Hero : MonoBehaviour
{   

/*
    private float _directionHor;
    private float _directionVert; 


*/
    [SerializeField] private float _speed;
    private Vector2 _direction; 
    
    public void SetDirection(Vector2 direction)
    {
      _direction = direction;
    }
/*
    public void SetDirectionHor(float direction)
    {
      _directionHor = direction;
    }
    public void SetDirectionVert(float direction)
    {
      _directionVert = direction;
    }

*/



    private void Update()
    {

        if (_direction.magnitude > 0)
        {
          var delta = _direction * _speed * Time.deltaTime;
          transform.position = transform.position + new Vector3 (delta.x, delta.y, transform.position.z);
        }


      /*
      if (_directionHor != 0)
      {
        var deltaHor = _directionHor * _speed * Time.deltaTime; 
        var newXPos = transform.position.x + deltaHor; 
        transform.position = new Vector3(newXPos, transform.position.y, transform.position.z);

      } else if ( _directionVert  != 0)
      {
        var deltaVert = _directionVert * _speed * Time.deltaTime; 
        var newYPos = transform.position.y + deltaVert; 
        transform.position = new Vector3(transform.position.x, newYPos, transform.position.z);

      }
      
      

       if (_directionHor != 0 ||  _directionVert  != 0 )
      {
        var deltaHor = _directionHor * _speed * Time.deltaTime; 
        var newXPos = transform.position.x + deltaHor; 
        transform.position = new Vector3(newXPos, transform.position.y, transform.position.z);

      } else if ( _directionVert  != 0)
      {
        var deltaVert = _directionVert * _speed * Time.deltaTime; 
        var newYPos = transform.position.y + deltaVert; 
        transform.position = new Vector3(transform.position.x, newYPos, transform.position.z);

      }

      */




      


    }


    public void SaySmth()
    {
      Debug.Log("Smth");
    }





    
}
}

