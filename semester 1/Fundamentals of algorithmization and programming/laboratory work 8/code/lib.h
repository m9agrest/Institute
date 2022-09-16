#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <conio.h>

void start();
void end();
typedef struct info_t Info;
void InfoPrint(Info *arr, int n);
struct tm InfoDate();
int my_scan_int(char *text);
float my_scan_float(char *text);
char *my_scan_string(char *text);
void Generation(Info *arr, int n);


#include "lib.c"