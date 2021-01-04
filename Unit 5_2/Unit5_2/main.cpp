//=========================================
//  main.cpp
//  Unit5_2
//  Due Date: December 20, 2020
//  Created by Xavier Greer
//=========================================

#include <iostream>
#include <list>
//since I'm using mac I have to include it this way
#include "/Users/xaviergreer/stdc++.h"

using namespace std;

#define V 4
int TSP(int graph[][V], int s) {
    vector<int> List;
    for (int i = 0; i < V; i++){
        if (i != s)
            List.push_back(i);
    }
    int MIN = INT_MAX;
    do {
        int current = 0;
        int k = s;
        for (int i = 0; i < List.size(); i++) {
            current += graph[k][List[i]];
            k = List[i];
        }
        current += graph[k][s];
        MIN = min(MIN, current);
 
    } while (
        next_permutation(List.begin(), List.end()));
 
    return MIN;
}

int main(int argc, const char * argv[]) {

    int graph[][V] = { { 0, 10, 15, 20 },
                       { 10, 0, 35, 25 },
                       { 15, 35, 0, 30 },
                       { 20, 25, 30, 0 } };
    int s = 0;
    cout << TSP(graph, s) << endl;
    return 0;
}
