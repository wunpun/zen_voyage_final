using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class change_mode : MonoBehaviour
{
    public Material mat1;
    public Material mat2;


        public void night_shift()
    {
        RenderSettings.skybox = mat1;
    }
        public void day_shift()
    {
        RenderSettings.skybox = mat2;
    }

}
