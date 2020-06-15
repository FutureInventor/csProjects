using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;
using System.Collections;
using UnityEngine;

public class unityParticleSimulation : MonoBehaviour
{
    public Vector3 TargetPosition;
    public float RotationSpeed = 0.5F;
    public Quaternion _lookRotation;
    public Vector3 _direction;
    public GameObject[] cylinder;
    public GameObject[] sphere;
    public TextAsset textFile;
    public Shader shader1;

    void Start()
    {
        int startIndex2 = 43;
        int lenght2 = 40;
        int rows3 = 40;
        int columns3 = 3;
        string[] tab_3 = File.ReadAllLines(@"C:\Users\karol\Desktop\txxxt.txt");
        var tab3 = tab_3.Skip(startIndex2).Take(lenght2).ToArray();
        double[,] matrix3 = new double[rows3, columns3];
        for (int i = 0; i < 35; i++)
        {
            string[] tmp3 = tab3[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < tmp3.Length; j++)
            {
                matrix3[i, j] = Double.Parse(tmp3[j], CultureInfo.InvariantCulture);
            }
        }

        cylinder = new GameObject[40];
        sphere = new GameObject[7];

        for (int i = 0; i < 35; i++)
        {
            float x = (float)matrix3[i, 0];
            float y = (float)matrix3[i, 1];
            float z = (float)matrix3[i, 2];
            cylinder[i] = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            cylinder[i].transform.position = new Vector3(x, y, z);
            cylinder[i].transform.localScale -= new Vector3(0.95F, 0.6F, 0.95F);
            Renderer rend = cylinder[i].GetComponent<Renderer>();
            rend.material.shader = Shader.Find("_Color");
            rend.material.SetColor("_Color", Color.green);
            rend.material.shader = Shader.Find("Specular");
            rend.material.SetColor("_SpecColor", Color.red);
            rend.material.shader = shader1;
        }
        for (int i = 0; i < 7; i++)
        {
            float x = (float)matrix3[i, 0];
            float y = (float)matrix3[i, 1];
            float z = (float)matrix3[i, 2];
            sphere[i] = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere[i].transform.position = new Vector3(x, y, z);
            sphere[i].transform.localScale -= new Vector3(0.8F, 0.8F, 0.8F);
        }

    }

    void Update()
    {

        int startIndex1 = 1;
        int lenght1 = 40;
        int rows2 = 40;
        int columns2 = 3;
        string[] tab_2 = File.ReadAllLines(@"C:\Users\karol\Desktop\txxxt.txt");
        var tab2 = tab_2.Skip(startIndex1).Take(lenght1).ToArray();
        double[,] matrix2 = new double[rows2, columns2];
        for (int i = 0; i < 40; i++)
        {
            string[] tmp2 = tab2[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < tmp2.Length; j++)
            {
                matrix2[i, j] = Double.Parse(tmp2[j], CultureInfo.InvariantCulture);
            }
        }
        for (int i = 0; i < 40; i++)
        {
            float x = (float)matrix2[i, 0];
            float y = (float)matrix2[i, 1];
            float z = (float)matrix2[i, 2];
            TargetPosition = new Vector3(x, y, z);
            _direction = (TargetPosition - cylinder[i].transform.position).normalized;
            _lookRotation = Quaternion.LookRotation(_direction);
            cylinder[i].transform.rotation = Quaternion.Slerp(cylinder[i].transform.rotation, _lookRotation, Time.deltaTime * RotationSpeed);
        }

    }
}

