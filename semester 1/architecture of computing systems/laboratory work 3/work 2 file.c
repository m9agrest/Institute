#include <stdio.h>
#include <stdlib.h> 
#include <conio.h>
#include <time.h>

void PercentInfo(int N, int I){
	int p =((float) I / N) * 100;
	printf("\r%d%c",p,37);
}

int main(){
	srand(time(NULL));
	char name[32];
	int n, min, max;
	
	printf("Введите имя файла: ");
	scanf("%s", &name);
	getchar();

	if(fopen(name, "r")){
		printf("\nВы действительно хотите перезаписать содержимое файла?\n+ да\n- нет\n");
		char c = getch();
		while(c!='-'&&c!='+'){ c = getch(); }
		if(c=='-'){
			return 0;
		}
	}
	FILE *file = fopen(name, "w");


	printf("Введите кол-во элементов массива: ");
	scanf("%d", &n);
	getchar();
	printf("Введите минимальный элемент: ");
	scanf("%d", &min);
	getchar();
	printf("Введите максимальный элемент: ");
	scanf("%d", &max);
	getchar();


	if(max<min){
		int a = min;
		min = max;
		max = a;
	}


	printf("\nГенерация файла:\n");
	for(int i = 0; i < n; i++){

		int r = rand()%(max - min + 1) + min;

		if(i==(n-1)){
			fprintf(file,"%d",r);
		}else{
			fprintf(file,"%d\n",r);
		}

		if(i%10==0){
			PercentInfo(n,i);
		}
	}
	fclose(file);
	printf("\rготово\n");
	getchar();
	return 0;
}