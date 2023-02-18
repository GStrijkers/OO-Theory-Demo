using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class CruiseShip : Boat
{
  public CruiseShip() : base() { maxPassengers = 2000; }

  //POLYMORPHISM
  public override void Move(Vector3 newPosition)
  {
    if (newPosition.y > 0)
    {
      Debug.Log("Cruiseship cann't fly");
      return;
    }
    if (newPosition.y < 0)
    {
      Debug.Log("Cruiseship cann't dive");
      return;
    }
    base.Move(newPosition);
  }
}
