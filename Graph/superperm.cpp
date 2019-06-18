#include "stdafx.h"
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

int getOverlap(string fromName, string toName, int i, int j) {
  if (i == fromName.size()) {
    return 0;
  }
  if (fromName[i] == toName[j]) {
    return getOverlap(fromName, toName, i + 1, j + 1) + 1;
  } else {
    if (j > 0) {
      return - j + 1;
    } else {
      return getOverlap(fromName, toName, i + 1, j);
    }
  }
}

int getSuperpermutationWeight(int N, Vertex * fromVertex, Vertex * toVertex) {
  return N - getOverlap(fromVertex->name, toVertex->name, 0, 0);
}

vector<Edge *> createSuperPermutationEdges(int N, vector<Vertex *> vertices) {
  vector<Edge *> edges;
  for (int i = 0; i < vertices.size(); i++) {
    for (int j = 0; j < vertices.size(); j++) {
      if (i != j) {
        int weight = getSuperpermutationWeight(N, vertices[i], vertices[j]);
        Edge * edge = new Edge(vertices[i], vertices[j], weight);
        edges.push_back(edge);
      }
    }
  }
  return edges;
}

Graph createSuperPermutationGraph(int N) {
  Graph graph;
  graph.vertices = createSuperPermutationVertices(N);
  graph.edges = createSuperPermutationEdges(N, graph.vertices);
  return graph;
}

