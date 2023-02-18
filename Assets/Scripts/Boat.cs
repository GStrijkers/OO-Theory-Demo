using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
  protected int maxPassengers;
  private List<string> Passengers = new List<string>();

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }
  //ENCAPSULATION
  public void AddPassenger(string passenger)
  {
    if (Passengers.Count < maxPassengers) 
    { 
      Passengers.Add(passenger);
    }
    else { Debug.Log("Sorry, the boat is full !!!"); }
  }

  //ABSTRACTION
  public virtual void Move(Vector3 newPosition)
  {
    transform.Translate(newPosition);
  }

  public void PrintPassengersList()
  {
    foreach(string passenger in Passengers) { Debug.Log(passenger); }
  }
}
