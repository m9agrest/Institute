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
	
	printf("������ ��� 䠩��: ");
	scanf("%s", &name);
	getchar();

	if(fopen(name, "r")){
		printf("\n�� ����⢨⥫쭮 ��� ��१������ ᮤ�ন��� 䠩��?\n+ ��\n- ���\n");
		char c = getch();
		while(c!='-'&&c!='+'){ c = getch(); }
		if(c=='-'){
			return 0;
		}
	}
	FILE *file = fopen(name, "w");


	printf("������ ���-�� ����⮢ ���ᨢ�: ");
	scanf("%d", &n);
	getchar();
	printf("������ ��������� �����: ");
	scanf("%d", &min);
	getchar();
	printf("������ ���ᨬ���� �����: ");
	scanf("%d", &max);
	getchar();


	if(max<min){
		int a = min;
		min = max;
		max = a;
	}


	printf("\n������� 䠩��:\n");
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
	printf("\r��⮢�\n");
	getchar();
	return 0;
}