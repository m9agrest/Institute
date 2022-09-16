#include <stdio.h>
#include <stdlib.h>
#include <string.h>
int main()
{
	int count =1;
	char str[5] = "bbbbb";
	printf("2)");
	for (int i = 0; i < 5; i++){
		if (str[i] == str[i+1]){
			count++;
		}else{
			break;
		}
	}
	printf("%d",count);
	getchar();
	return 0;
}
