#ifndef SUPERPERM_H
#define SUPERPERM_H
#include "graph.h"
#include <vector>

vector<Vertex *>  createSuperPermutationVertices(int N);
vector<Edge *>    createSuperPermutationEdges(vector<Vertex *> vertices);
Graph             createSuperPermutationGraph(int N);


#endif