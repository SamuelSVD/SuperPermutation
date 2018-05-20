#include "superperm.h"

void createSuperpermVertices(int N, int i, string name, vector<Vertex *> * vertices) {
  if (i == N) {
    Vertex * v = new Vertex(name);
    vertices->push_back(v);
  } else {
    for (int j = 0; j < N; j++) {
      char c = (char)('0' + j);
      string::size_type index = name.find(c,0);
      if (index == string::npos) {
        createSuperpermVertices(N, i+1, name + c, vertices);
      }
    }
  }
}

vector<Vertex *> createSuperPermutationVertices(int N) {
  vector<Vertex *> vertices;
  createSuperpermVertices(N, 0, "", &vertices);
  return vertices;
}

vector<Edge *> createSuperPermutationEdges(vector<Vertex *> vertices) {
  vector<Edge *> edges;
  return edges;
}

Graph createSuperPermutationGraph(int N) {
  Graph graph;
  graph.vertices = createSuperPermutationVertices(N);
  graph.edges = createSuperPermutationEdges(graph.vertices);
  return graph;
}

