#include<stdio.h>
void main() {
	double x,y;
	printf("enter x: ");
	scanf("%lf", &x);
	getchar();
	printf("enter y: ");
	scanf("%lf", &y);
	getchar();

	int a = 0;

	if (y > 0) { a += 1; } 
	else if (y == 0) { a += 2; } 
	else { a += 3; }

	if (x > 0) { a += 10; } 
	else if(x == 0){ a += 20; } 
	else { a += 30; }

	switch (a) {
		case 11:
			printf("   |   \n");
			printf("   | * \n");
			printf("   |   \n");
			printf("-------\n");
			printf("   |   \n");
			printf("   |   \n");
			printf("   |   \n");
			break;
		case 12:
			printf("   |   \n");
			printf("   |   \n");
			printf("   |   \n");
			printf("-----*-\n");
			printf("   |   \n");
			printf("   |   \n");
			printf("   |   \n");
			break;
		case 13:
			printf("   |   \n");
			printf("   |   \n");
			printf("   |   \n");
			printf("-------\n");
			printf("   |   \n");
			printf("   | * \n");
			printf("   |   \n");
			break;
		case 21:
			printf("   |   \n");
			printf("   *   \n");
			printf("   |   \n");
			printf("-------\n");
			printf("   |   \n");
			printf("   |   \n");
			printf("   |   \n");
			break;
		case 22:
			printf("   |   \n");
			printf("   |   \n");
			printf("   |   \n");
			printf("---*---\n");
			printf("   |   \n");
			printf("   |   \n");
			printf("   |   \n");
			break;
		case 23:
			printf("   |   \n");
			printf("   |   \n");
			printf("   |   \n");
			printf("-------\n");
			printf("   |   \n");
			printf("   *   \n");
			printf("   |   \n");
			break;
		case 31:
			printf("   |   \n");
			printf(" * |   \n");
			printf("   |   \n");
			printf("-------\n");
			printf("   |   \n");
			printf("   |   \n");
			printf("   |   \n");
			break;
		case 32:
			printf("   |   \n");
			printf("   |   \n");
			printf("   |   \n");
			printf("-*-----\n");
			printf("   |   \n");
			printf("   |   \n");
			printf("   |   \n");
			break;
		case 33:
			printf("   |   \n");
			printf("   |   \n");
			printf("   |   \n");
			printf("-------\n");
			printf("   |   \n");
			printf(" * |   \n");
			printf("   |   \n");
			break;
	}
	getchar();
}