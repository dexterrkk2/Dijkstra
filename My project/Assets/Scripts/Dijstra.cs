using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class Dijstra
{
    class NodeRecord: IComparable<NodeRecord>
    {
        public Node node;
        public Connection connection;
        public float costSoFar;
        public int CompareTo(NodeRecord other)
        {
            if (other == null)
            {
                return 1;
            }
            return (int)(costSoFar - other.costSoFar);
        }
    }
    public static  List<Connection> Pathfind(Graph graph, Node start, Node end)
    {
        
    }
}
