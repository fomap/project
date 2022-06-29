using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class Hero : MonoBehaviour
{   
    private float _directionHor;
    private float _directionVert; 
    [SerializeField] private float _speed;

    public void SetDirectionHor(float direction)
    {
      _directionHor = direction;
    }
    public void SetDirectionVert(float direction)
    {
      _directionVert = direction;
    }





    private void Update()
    {
      
      if (_directionHor != 0)
      {
        var deltaHor = _directionHor * _speed * Time.deltaTime; 
        var newXPos = transform.position.x + deltaHor; 
        transform.position = new Vector3(newXPos, transform.position.y, transform.position.z);

      } else 
      {
        var deltaVert = _directionVert * _speed * Time.deltaTime; 
        var newYPos = transform.position.y + deltaVert; 
        transform.position = new Vector3(transform.position.x, newYPos, transform.position.z);

      }



    }


    public void SaySmth()
    {
      Debug.Log("Smth");
    }
}
}

