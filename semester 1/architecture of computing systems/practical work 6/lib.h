//генерирует двойной массив и выводит его на экран
int **array_2d_generation(int size_col, int size_line, int min, int max);void array_2d_print(int **arr, int size_col, int size_line, int min, int max);//выводит на экран двойно массив

//выводит кол-во знаков в числе
int n_space(int num);

//выводит число с учетом пробелов, для красивой визуализации
void array_2d_print_num(int num, int Nspace);

//выводит гор. линию таблицы
void array_2d_print_line(int size_col, int Nspace, int NspaceLine);

//выводит гор. линию отчерчивающая шапку таблицы
void array_2d_print_line_head(int size_col, int Nspace, int NspaceLine);

#include "lib.c"