using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
  manage groups of units
*/
public class UnitCollection {

private:
  Vector<Unit> units;
  Dictionary<string, Vector<Unit>> unit_groups;

  public void Start () {}
  public void Update () {}
}