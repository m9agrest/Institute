float R1, L2, S1, S01, S2, S02;

typedef struct point_t{ float x, y; }Point;

float RandFloat(float min, float max){ return (((float)rand()/(float)(RAND_MAX)) * (max - min)) + min; }

Point PointGeneration(float Xmin, float Xmax, float Ymin, float Ymax){
	Point a;
	a.x = RandFloat(Xmin, Xmax);
	a.y = RandFloat(Ymin, Ymax);
	return a;
}

int PointCheck1(Point point){
	if((pow(point.x,2) + pow(point.y,2)) <= 2){
		if(point.y > 0){
			if(pow(point.x,2) <= point.y){
				return 0;
			}
		}
		return 1;
	}
	return 0;
}

int PointCheck2(Point point){
	if((pow(point.x,2) + pow(point.y,2)) < 3){
		return 0;
	}
	point.y += 4.5;
	point.x *= -1;
	if(point.x > point.y){
		return 0;
	}
	return 1;
}

float PointSquare(int n, int true, float S0){
	return (float) ((float) true / n) * S0;
}



void func(int n, int Shape){
	printf("%i точек:\n", n);
	int true = 0;
	for(int i = 0; i < n; i++){
		switch (Shape){
			case 1:
				true += PointCheck1(PointGeneration(-R1, R1, -R1, R1));
				break;
			case 2:
				true += PointCheck2(PointGeneration(-L2,0,-L2,0));
				break;
		}
	}

	float S;
	switch (Shape){
		case 1:
			S = PointSquare(n, true, S01);
			break;
		case 2:
			S = PointSquare(n, true, S02);
			break;
	}
	
	printf("Площадь получилась: %f\n", S);
	printf("отклонение: %f\n", S1 - S);
	printf("попавшие точки: %i\n\n", true);
}