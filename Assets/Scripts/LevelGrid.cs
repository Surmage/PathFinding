using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGrid
{
    public List<Node>nodeList = new List<Node>();
    public float cellSize = 0.5f;
    
    public LevelGrid(float cellSize)
    {
        this.cellSize = cellSize;
    }
    private Vector3 getWorldPosition(float x, float y)
    {
        return new Vector3(x, y) * cellSize / 10;
    }
    public void addNode(Node n)
    {
        nodeList.Add(n);
    }
    public void drawNodes()
    {
        //drawNode();
        float precision = 10;
        foreach (Node n in nodeList)
        {
            Debug.DrawLine(getWorldPosition(n.x - precision, n.y - precision), getWorldPosition(n.x - precision, n.y + precision), Color.white, 100f);
            Debug.DrawLine(getWorldPosition(n.x - precision, n.y + precision), getWorldPosition(n.x + precision, n.y + precision), Color.white, 100f);
            Debug.DrawLine(getWorldPosition(n.x + precision, n.y + precision), getWorldPosition(n.x + precision, n.y - precision), Color.white, 100f);
            Debug.DrawLine(getWorldPosition(n.x + precision, n.y - precision), getWorldPosition(n.x - precision, n.y - precision), Color.white, 100f);
        }
    }
    private void drawNode()
    {
        float test = 0.1f;
        Debug.DrawLine(getWorldPosition(- test,- test), getWorldPosition(-test, test), Color.white, 100f);
        Debug.DrawLine(getWorldPosition(-test, test), getWorldPosition(test, test), Color.white, 100f);
        Debug.DrawLine(getWorldPosition(test, test), getWorldPosition(test, -test), Color.white, 100f);
        Debug.DrawLine(getWorldPosition(test, -test), getWorldPosition(-test, -test), Color.white, 100f);
    }
}
