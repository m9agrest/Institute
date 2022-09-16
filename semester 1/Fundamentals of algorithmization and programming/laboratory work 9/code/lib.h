float R1, L2, S1, S01, S2, S02;

typedef struct point_t Point;

float RandFloat(float min, float max);
Point PointGeneration(float Xmin, float Xmax, float Ymin, float Ymax);

float PointSquare(int n, int true, float S0);

int PointCheck1(Point point);
int PointCheck2(Point point);

void func(int n, int Shape);

void ConsolePercent(int Max, int I);
void ConsolePercentClear();

#include "lib.c"