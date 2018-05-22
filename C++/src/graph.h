#ifndef GRAPH_H
#define GRAPH_H

#include <vector>
#include <string>

using namespace std;
class Edge;

class Vertex {
  public:
    string name;
    vector<Edge *> edges;
    Vertex(string name);
};

class Edge {
  public:
    Vertex * fromVertex;
    Vertex * toVertex;
    int weight;
    Edge(Vertex * fromVertex, Vertex * toVertex, int weight);
};

class Graph {
  public:
    vector<Vertex *> vertices;
    vector<Edge *> edges;
};

vector<Edge *> dijkstra(Vertex * fromVector, Vertex * toVector, vector<Vertex *> vertices);

#endif
