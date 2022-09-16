#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(){
	char str[15] = "­­¬¬­­¬¬¬­­¨¬­­";
	for (int i = 0; i + 1 < 15; i++)
	if (str[i] == str[i + 1] && str[i] == '­'){
		printf("%c%c\n",str[i],str[i+1]);
	}
	getchar();
	return 0;
}