using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waves : MonoBehaviour
{
    // Start is called before the first frame update
    public Mesh mesh;
    public Vector3[] newVertices;
    public Vector2[] newUV;
    public int[] newTriangles;
    public int xSize = 20;
    public int zSize = 20;
    [SerializeField] float meshrangex;
    [SerializeField] float meshrangey;
    [SerializeField] public Gradient mapcolors;
    Color[] colors;


    float maxheight;
    float minheight;
    public float perlinRange;
    public float perlinRange2therevenge;

    public float wavespeed;
    
    public bool update;
    public float test;
 



    void Start()
    {
        test = Random.Range(1, 10000);
        

        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        CreateShape();
        CreateHeight();
        UpdateMesh();

    }

    // Update is called once per frame
    void Update()
    {
        if (update == true)
        {
            meshchecker();
            UpdateMesh();
        }
    }

    void meshchecker()
    {
        for (int z = 0, i = 0; z <= zSize; z++)
        {
            for (int x = 0; x <= xSize; x++)
            {

                float y = Mathf.PerlinNoise((x + test) * perlinRange, (z + test) * perlinRange) * perlinRange2therevenge;
                

                

                newVertices[i].y = y;

                if (y > maxheight) maxheight = y;
                if (y < minheight) minheight = y;



                i++;
            }

        }

        test += wavespeed;

        for (int z = 0, i = 0; z <= zSize; z++)
        {
            for (int x = 0; x <= xSize; x++)
            {

                float height = Mathf.InverseLerp(minheight, maxheight, newVertices[i].y);
                colors[i] = mapcolors.Evaluate(height);
                i++;
            }

        }

    }

    void UpdateMesh()
    {

        mesh.Clear();
        mesh.vertices = newVertices;
        mesh.triangles = newTriangles;
        mesh.colors = colors;
        mesh.RecalculateNormals();
    }
    void CreateHeight()
    {
        for (int z = 0, i = 0; z <= zSize; z++)
        {
            for (int x = 0; x <= xSize; x++)
            {

                float y = Mathf.PerlinNoise((x + test) * perlinRange, (z + test) * perlinRange) * perlinRange2therevenge;
                

               

                newVertices[i].y = y;

                if (y > maxheight) maxheight = y;
                if (y < minheight) minheight = y;



                i++;
            }

        }
        for (int z = 0, i = 0; z <= zSize; z++)
        {
            for (int x = 0; x <= xSize; x++)
            {

                float height = Mathf.InverseLerp(minheight, maxheight, newVertices[i].y);
                colors[i] = mapcolors.Evaluate(height);
                i++;
            }

        }

    }
    void CreateShape()
    {
        newVertices = new Vector3[(xSize + 1) * (zSize + 1)];
        colors = new Color[newVertices.Length];

        for (int z = 0, i = 0; z <= zSize; z++)
        {
            for (int x = 0; x <= xSize; x++)
            {

                float y = Mathf.PerlinNoise(x * perlinRange, z * perlinRange) * perlinRange2therevenge;
                newVertices[i] = new Vector3(x + 1, y, z + 1);
                i++;
                if (y > maxheight) maxheight = y;
                if (y < minheight) minheight = y;
            }

        }

        int vert = 0;
        int tris = 0;
        newTriangles = new int[xSize * zSize * 6];
        for (int z = 0; z < zSize; z++)
        {
            for (int x = 0; x < xSize; x++)
            {


                newTriangles[tris + 0] = vert + 0;
                newTriangles[tris + 1] = vert + xSize + 1;
                newTriangles[tris + 2] = vert + 1;
                newTriangles[tris + 3] = vert + 1;
                newTriangles[tris + 4] = vert + xSize + 1;
                newTriangles[tris + 5] = vert + xSize + 2;

                vert++;
                tris += 6;
            }
            vert++;
        }

        for (int z = 0, i = 0; z <= zSize; z++)
        {
            for (int x = 0; x <= xSize; x++)
            {

                float height = Mathf.InverseLerp(minheight, maxheight, newVertices[i].y);
                colors[i] = mapcolors.Evaluate(height);
                i++;
            }

        }

    }
}
