using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_player : MonoBehaviour
{
   public void move_to_settings()
    {
        transform.position = GameObject.Find("settings_menu").transform.position;
    }
    public void move_to_main() {
        transform.position = new Vector3(376.327f, 6.267f, 157.4f);
        transform.Rotate(0, 40, 0);
    }

    public void move_to_world()
    {
        transform.position = new Vector3(56.86f, 1.68f, 133.1f);
        transform.Rotate(0, 220, 0);
    }
}
