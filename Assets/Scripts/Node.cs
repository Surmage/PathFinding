using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    public bool walkable;
    public string type;
    public int x;
    public int y;
    Node previousNode = null;
    public Node(bool walkable, string type, int x, int y) {
        this.walkable = walkable;
        this.type = type;
        this.x = x;
        this.y = y;
    }
    public void setPrevNode(Node prevNode)
    {
        previousNode = prevNode;
    }

}
