using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
 public GameObject human;
 public float value;
 public Vector3 sizeChange;

 public void Moveup()
 {
 value = value + 0.5f;
human.transform.position = new Vector3(value, 8.4f , 45.2f);
 }
  public void Rotate()
 {
     human.transform.Rotate(0f,4f,0f);
 }
 public void Grow()
{
human.transform.localScale = human.transform.localScale + sizeChange;
}
public void ResetHuman()
{
    human.transform.position = new Vector3(56.5f, 8.4f ,45.2f);
    human.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
    human.transform.localScale = new Vector3(2.791607f, 2.573618f, 2.0559f);
}
}
