#include <stdio.h>
void main(){
	int a = 1281;
	int *p = &a;
	for (int i = 0; i < sizeof(int); i++){
		printf("%hhd ", *(((unsigned char *) &a) + i));
	}
	
}