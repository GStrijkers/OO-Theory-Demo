using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Canoe : Boat
{
  public Canoe() : base() { maxPassengers = 2; }

  //POLYMORPHISM
  public override void Move(Vector3 newPosition)
  {
    if (newPosition.y > 0)
    {
      Debug.Log("Canoe cann't fly");
      return;
    }
    if (newPosition.y < 0)
    {
      Debug.Log("Canoe cann't dive");
      return;
    }

    base.Move(newPosition);
  }
}
