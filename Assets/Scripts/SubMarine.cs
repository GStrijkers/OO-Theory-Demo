using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class SubMarine : Boat
{
  public SubMarine() : base() { maxPassengers = 120; }

  //POLYMORPHISM
  public override void Move(Vector3 newPosition)
  {
    if (newPosition.y > 0)
    {
      Debug.Log("Cruiseship cann't fly");
      return;
    }

    base.Move(newPosition); 
  }
}
