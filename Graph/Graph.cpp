#include "stdafx.h"
#include "graph.h"

Vertex::Vertex(string name) {
	this->name = name;
	this->edges = new vector<Edge *>();
}

void Vertex::createEdge(Vertex * toVertex, int weight) {
	this->edges->push_back(new Edge(this, toVertex, weight));
}


Edge::Edge(Vertex * fromVertex, Vertex * toVertex, int weight) {
	this->fromVertex = fromVertex;
	this->toVertex = toVertex;
	this->weight = weight;
}

vector<Edge *> dijkstra(Vertex * fromVertex, Vertex * toVertex, vector<Vertex *> vertices) {
	vector<Edge *> solution;
	return solution;
}

/*	
Edge * getEdge(fromV, toV, weight) {
	return new Edge(fromV, toV, weight)
}

def getEdges(fromV, edgeList):
result = []
for edge in edgeList:
if (edge[0] == fromV):
result.append(edge)
return result

def generateVerticesSupPerm(N):
vertices = []
return vertices

def generateEdgesSupPerm(vertices):
edges = []
return edges

def generateGraphSupPerm(N):
graph = []
vertices = generateVerticesSupPerm(N)
edges = generateEdgesSupPerm(vertices)
for vertex in vertices:
temp_edges = getEdges(vertex, edges)
graph.append([vertex, temp_edges])
return graph

def getNearestVertexEdges(vertex):
min = None
result = []
for edge in vertex[1]:
if

graph = generateGraphSupPerm(N)
*/