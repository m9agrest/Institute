#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(){
	char s1[20] = "Америка(США)";
	char s2[20] = "Российская Федерация";
	char t1[20];
	char t2[20];
	printf("The string s1: ");
	puts(s1);
	printf("The string s2: ");
	puts(s2);
	strcpy(t1, s1);
	puts("The result of strcpy(t1, s1) ");
	puts(t1);
	strcpy(t2, s2);
	puts("The result of strcpy(t2, s2) ");
	puts(t2);
	getchar();
	return 0;
}