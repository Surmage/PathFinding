using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMap : MonoBehaviour
{   
    public void Start()
    {
        LevelGrid g = new LevelGrid(10f);
        //Walkable map is 14x14, including border it's 16x16
        string[] lines = System.IO.File.ReadAllLines(@"Assets\GridMaps\Map1.txt");
        //Debug.Log(lines[15]);
        int y = 0;
        for (int x = 0; x<lines.Length; x++)
        {
            foreach (char letter in lines[x])
            {              
                Node n = new Node(true, "dunno", x, y);
                //Debug.Log(g.cellSize);
                g.addNode(n);
                y++;
            }
            y = 0;
        }
        g.drawNodes();
    }

  
}
