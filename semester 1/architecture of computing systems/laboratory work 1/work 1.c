#include <stdio.h>
void main(){
	char ch = 1, *chs = &ch;
	short sh = 12, *shs = &sh;
	int in = 10, *ins = &in;
	float fl = 9.98, *fls = &fl;
	double lf = 87.11, *lfs = &lf;
	
	printf("char %c\n", *chs);
	printf("short %hi\n", *shs);
	printf("int %d\n", *ins);
	printf("float %f\n", *fls);
	printf("double %lf\n", *lfs);
	getchar();
}