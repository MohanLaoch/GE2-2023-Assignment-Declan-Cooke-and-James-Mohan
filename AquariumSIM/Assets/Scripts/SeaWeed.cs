using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaWeed : MonoBehaviour
{
    public float scale;
    public float waveSpeed;
    public float waveFrequency;


    void Update()
    {

        {
            MeshFilter mF = GetComponent<MeshFilter>();

            Vector3[] verts = mF.mesh.vertices;


            for (int i = 0; i < verts.Length; i++)
            {
                float pX = (verts[i].x * scale) + (Time.time * waveSpeed);
                float pY = (verts[i].y * scale) + (Time.time * waveSpeed);
                
                verts[i].z = Mathf.PerlinNoise(pX, pY) * waveFrequency;

            }


            
            mF.mesh.vertices = verts;
            
            mF.mesh.RecalculateNormals();
             
            mF.mesh.RecalculateBounds();

        }
    }
}
