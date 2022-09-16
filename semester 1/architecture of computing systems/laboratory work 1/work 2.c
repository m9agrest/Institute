#include <stdio.h>
void main(){
	char ch = 1, *chs = &ch;
	short sh = 12, *shs = &sh;
	int in = 10, *ins = &in;
	float fl = 9.98, *fls = &fl;
	double lf = 87.11, *lfs = &lf;
	
	printf("char  : %d, %d\n",sizeof(ch), sizeof(*chs));
	printf("short : %d, %d\n",sizeof(sh), sizeof(*shs));
	printf("int   : %d, %d\n",sizeof(in), sizeof(*ins));
	printf("float : %d, %d\n",sizeof(fl), sizeof(*fls));
	printf("double: %d, %d\n",sizeof(lf), sizeof(*lfs));
	
	getchar();
}