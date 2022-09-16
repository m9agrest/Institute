#include<stdio.h>

void main() {
	for (int i = 1000; i < 10000; i++) {
		if ((i % 133 == 125) && (i % 134 == 11)) {
			printf("%d\n",i);
		}
	}
	getchar();
}