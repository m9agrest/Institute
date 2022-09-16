#include <stdio.h>
#include <string.h>

int main(){
	char *str = "клоун";
	printf("Source string: %s\n", str);
	char new[5];
	new[0] = str[3];
	strncpy(&new[1],&str[0],3);
	new[4] = str[4];
	printf("Result string: %s\n", new);
	new[0]=str[0];
	new[1]=str[2];
	new[2]=str[1];
	strncpy(&new[3],&str[3],2);
	printf("Result string: %s\n", new);
	new[0]=str[0];
	new[1]=str[3];
	strncpy(&new[2],&str[1],2);
	printf("Result string: %s\n", new);
	getchar();
	return 0;
}