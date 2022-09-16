void start();//подключает utf8 и устанавливает srand
void end();//уведомляет о конце программы и ждет enter для закрытия


int **array_2d_generation(int size_col, int size_line, int min, int max);//генерирует двойной массив и выводит его на экран
void array_2d_print(int **arr, int size_col, int size_line, int min, int max);//выводит на экран двойно массив
int n_space(int num);//выводит кол-во знаков в числе
void array_2d_print_num(int num, int Nspace);//выводит число с учетом пробелов, для красивой визуализации
void array_2d_print_line(int size_col, int Nspace, int NspaceLine);//выводит гор. линию таблицы
void array_2d_print_line_head(int size_col, int Nspace, int NspaceLine);//выводит гор. линию отчерчивающая шапку таблицы
int cycle();//продолжить или нет?
int my_scan(wchar_t *text);//считывает int число, с защитой от дурака
void clear_stdin();//отчищает буфер ввода
void array_print(int *arr, int n);//выводит одномерный массив


#include "lib.c"