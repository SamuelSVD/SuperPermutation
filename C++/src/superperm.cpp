#include "superperm.h"


vector<Vertex *> createSuperPermutationVertices(int N) {
  vector<Vertex *> vertices;
  return vertices;
}

vector<Edge *> createSuperPermutationEdges(vector<Vertex *> vertices) {
  vector<Edge *> edges;
  return edges;
}

Graph createSuperPermutationGraph(int N) {
  Graph graph;
  graph.vertices = createSuperPermutationVertices(1);
  graph.edges = createSuperPermutationEdges(graph.vertices);
  return graph;
}

