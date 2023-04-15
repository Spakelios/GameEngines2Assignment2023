using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maptest : MonoBehaviour
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

    public float fallofValue;
    public float heightCheck;

    public float originalRandX;
    public float originalRandY;
    public float perlinRange;

     float randx;
     float randz;

    float maxheight;
    float minheight;

    void Start()
    {
        randx = Random.Range(1, 10000);
        randz = Random.Range(1, 10000);
        originalRandX = randx;
        originalRandY = randz;

        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        CreateShape();
        //CreateHeight();
        UpdateMesh();
        colors = new Color[newVertices.Length];
    }

    // Update is called once per frame
    void Update()
    {
        meshchecker();
        UpdateMesh();
    }

    void meshchecker()
    {
        for (int z = 0, i = 0; z <= zSize; z++)
        {
            for (int x = 0; x <= xSize; x++)
            {

                float y = Mathf.PerlinNoise(randx * perlinRange, randz * perlinRange) * 2f;
                /*float test;
                float xv = x / (float)xSize * 2 - 1;
                float zv = z / (float)xSize * 2 - 1;
                float v = Mathf.Max(Mathf.Abs(xv), Mathf.Abs(zv));
                test = Mathf.Pow(v, fallofValue) / (Mathf.Pow(v, fallofValue) + Mathf.Pow(2.2f - 2.2f * v, fallofValue));
                print(newVertices.Length);
                y *= test;*/

                //if (y < heightCheck) y = -1;

                newVertices[i].y=y;

                if (y > maxheight) maxheight = y;
                if (y < minheight) minheight = y;

                randx++;
                randz++;
                i++;
            }

        }
        randx = originalRandX;
        randz = originalRandY;
        //originalRandX += 0.01f;
       // originalRandY += 0.01f;

        for (int z = 0, i = 0; z <= zSize; z++)
        {
            for (int x = 0; x <= xSize; x++)
            {

                float height = Mathf.InverseLerp(minheight, maxheight, newVertices[i].y);
                colors[i] = mapcolors.Evaluate(height);
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
        float[,] noiseMap = new float[xSize, xSize];
        for (int z = 0, i = 0; z <= zSize; z++)
        {
            for (int x = 0; x <= xSize; x++)
            {

                float randx = Random.Range(1f, meshrangex);
                float randy = Random.Range(1f, meshrangey);

                float y = Mathf.PerlinNoise(x*(Random.Range(0.1f,1f)), z* (Random.Range(0.1f, 1f))) *2;

               /* float xv = x / (float)xSize * 2 - 1;
                float zv = z / (float)xSize * 2 - 1;
                float v = Mathf.Max(Mathf.Abs(xv), Mathf.Abs(zv));
                test = Mathf.Pow(v, fallofValue) / (Mathf.Pow(v, fallofValue) + Mathf.Pow(2.2f - 2.2f * v, fallofValue));
                print(newVertices.Length);
                //y -= test;
                
                newVertices[i].y = y;
                i++;*/
            }
        }
        
    }
    void CreateShape()
    {
        newVertices = new Vector3[(xSize + 1) * (zSize + 1)];
        
        for (int z = 0, i = 0; z <= zSize; z++)
        {
            for (int x = 0; x <= xSize; x++)
            {
                
                float y = Mathf.PerlinNoise(randx * perlinRange, randz * perlinRange) * 2f;
                /*float test;
                float xv = x / (float)xSize * 2 - 1;
                float zv = z / (float)xSize * 2 - 1;
                float v = Mathf.Max(Mathf.Abs(xv), Mathf.Abs(zv));
                test = Mathf.Pow(v, fallofValue) / (Mathf.Pow(v, fallofValue) + Mathf.Pow(2.2f - 2.2f * v, fallofValue));
                print(newVertices.Length);
                y -= test; */

                newVertices[i] = new Vector3(x+1, y, z+1);
                randx++;
                randz++;
                i++;
            }
            
        }

        int vert = 0;
        int tris = 0;
        newTriangles = new int[xSize * zSize * 6];
        for(int z = 0; z<zSize; z++)
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
        
    }
}
