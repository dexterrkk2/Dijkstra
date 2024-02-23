using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Graph : MonoBehaviour
{
    List<Connection> connections;
    public List<Connection> getConnections(Node node)
    {
        List<Connection> _connections = new List<Connection>();
        foreach (Connection c in connections)
        {
            if (c.getFromNode() == node)
            {
                connections.Add(c);
            }
        }
        return connections;
    }

}
