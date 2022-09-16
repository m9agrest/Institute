#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <conio.h>

void start(){
	srand(time(NULL));
}

void end(){
	printf("\n\n\nКонец работы!\nнажмите enter чтобы закончить\n");
	getchar();
}

typedef struct info_t{
	char *id;
	char *name;
	struct tm Output;
	struct tm Input;
	float distance;
} Info;

void InfoPrint(Info *arr, int n){
	for(int i = 0; i < n; i++){
		char s[40];
		printf("Поезд %s\n%s\n", arr[i].id, arr[i].name);

		strftime(s, 40, "%d.%m.%Y %H:%M", &arr[i].Output);
		printf("Время отравления: %s\n", s);
		strftime(s, 40, "%d.%m.%Y %H:%M", &arr[i].Input);
		printf("Время прибытия: %s\n", s);

		printf("Расстояние: %f\n", arr[i].distance);

		int time = mktime(&arr[i].Input) - mktime(&arr[i].Output);
		time = time < 0? time * -1 : time;
		float speed = (arr[i].distance / time) * (60 * 60);
		printf("Средняя скорость: %.2fкм/ч\n", speed);
	}
}

void Generation(Info *arr, int n){
	for(int i = 0; i < n; i++){
		arr[i].id = my_scan_string("введите номер поезда ");
		arr[i].name = my_scan_string("введите маршрут ");

		printf("Введите дату отправления:\n");
		arr[i].Output = InfoDate();
		printf("Введите дату прибытия:\n");
		arr[i].Input = InfoDate();
		arr[i].distance = my_scan_float("введите растояние в км ");
	}
}

struct tm InfoDate(){
	const time_t timer = time(NULL);
	struct tm a = *localtime(&timer);
	a.tm_year = my_scan_int("Введите год ") - 1900;
	a.tm_mon = my_scan_int("Введите месяц ") - 1;
	a.tm_mday = my_scan_int("Введите день ");
	a.tm_hour = my_scan_int("Введите час ");
	a.tm_min = my_scan_int("Введите минуты ");
	a.tm_sec = 0;
	time_t next = mktime(&a);
	a = *localtime(&next);
	return a;
}


int my_scan_int(char *text){
	int a;
	printf(text);
	scanf("%i", &a);
	getchar();
	return a;
}
float my_scan_float(char *text){
	float a;
	printf(text); 
	scanf("%f", &a);
	getchar();
	return a;
}
char *my_scan_string(char *text){
	char *a = malloc(32 * sizeof(char));
	printf(text);
	scanf("%s", a);
	return a;
}