#include <stdio.h>
#include <stdlib.h>
void main(){
	int a = 100;
	int *as = &a;
	printf("a = %d\n", a);
	printf("adress = %p\n", *as);
	*as = *((int*)0x0128);//работать не должно, нельзя так просто сменить
	printf("%p %d", *as, *as);
	getchar();
}