using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {
    public Color purple;
    public SkinnedMeshRenderer headRenderer;
    public Mesh[] headMeshArray;
    private int headMeshIndex = 0;

    public SkinnedMeshRenderer handRenderer;
    public Mesh[] handMeshArry;
    private int handMeshIndex = 0;

    public SkinnedMeshRenderer[] bodyArray;

    private Color[] colorArray;
    private int colorIndex = -1;

    void Start()
    {
        colorArray = new Color[]{
            Color.blue,Color.cyan,Color.green,purple,Color.red
        };
        DontDestroyOnLoad(this.gameObject);
    }

    public void OnHeadMeshNext()
    {
        headMeshIndex++;
        headMeshIndex %= headMeshArray.Length;
        headRenderer.sharedMesh = headMeshArray[headMeshIndex];
    }
    public void OnHandMeshNext()
    {
        handMeshIndex++;
        handMeshIndex %= handMeshArry.Length;
        handRenderer.sharedMesh = handMeshArry[handMeshIndex];
    }
    public void OnChangeColorBlue()
    {
        colorIndex = 0;
        OnChangeColor(Color.blue);
    }
    public void OnChangColorCyan()
    {
        colorIndex = 1;
        OnChangeColor(Color.cyan);
    }
    public void OnChangeColorGreen()
    {
        colorIndex = 2;
        OnChangeColor(Color.green);
    }
    public void OnChangeColorPueple()
    {
        colorIndex = 3;
        OnChangeColor(purple);
    }
    public void OnChangColorRed()
    {
        colorIndex = 4;
        OnChangeColor(Color.red);
    }

    void OnChangeColor(Color c)
    {
        foreach (SkinnedMeshRenderer renderer in bodyArray)
        {
            renderer.material.color = c;
        }
    }
    void Save()
    {
        PlayerPrefs.SetInt("HeadMeshIndex", headMeshIndex);
        PlayerPrefs.SetInt("HandMeshIndex", handMeshIndex);
        PlayerPrefs.SetInt("ColorIndex", colorIndex);
    }
    public void OnPlay()
    {
        Save();
        Application.LoadLevel(1);
    }
}
