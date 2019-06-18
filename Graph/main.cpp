#include "stdafx.h"
#include "graph.h"
#include "superperm.h"

int main(int argc, char* argv[]) {
	int N = strtol(argv[1], NULL, 0);
	Graph graph = createSuperPermutationGraph(N);
	printf("Vertices: %d\r\n", graph.vertices.size());
	for (int i = 0; i < graph.vertices.size(); i++) {
		printf("%d: %s\r\n", i, graph.vertices[i]->name.c_str());
	}
	printf("Edges: %d\r\n", graph.edges.size());
	for (int i = 0; i < graph.edges.size(); i++) {
		printf("%d: %s -> %s : %d\r\n", i, graph.edges[i]->fromVertex->name.c_str(), graph.edges[i]->toVertex->name.c_str(), graph.edges[i]->weight);
	}
}