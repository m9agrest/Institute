#include <stdio.h>
#include <conio.h>
void summ(int a){
	static int n;
	if(a){
		int b = 0;
		for(int i=0; i <= a; i++){b+=i;}
		n++;
		printf("result:%d",b);
	}else{
		printf("col:%d",n);
	}
}
void main(){
	int a = 1;
	while(a){
		int b;
		printf("read :");scanf("%d",&b);getchar();
		summ(b);
		printf("\nnext y/n\n");
		char c = getch();
		while(c!='y'&&c!='n'){ c = getch(); }
		if(c=='n'){ a=0;}else{ printf("\n"); }
	}
}