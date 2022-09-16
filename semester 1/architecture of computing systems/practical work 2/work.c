#include <stdio.h>
void main() {
	int i;
	char c;
	short s;
	long l;
	long long ll;
	double d;
	float f;
	printf("size of (int) =%d bytes or %d bits\n", sizeof(i), sizeof(i)*8);
	printf("size of (char) =%d bytes or %d bits\n", sizeof(c), sizeof(c) * 8);
	printf("size of (short) =%d bytes or %d bits\n", sizeof(s), sizeof(s) * 8);
	printf("size of (long) =%d bytes or %d bits\n", sizeof(l), sizeof(l) * 8);
	printf("size of (long long) =%d bytes or %d bits\n", sizeof(ll), sizeof(ll) * 8);
	printf("size of (double) =%d bytes or %d bits\n", sizeof(d), sizeof(d) * 8);
	printf("size of (float) =%d bytes or %d bits\n", sizeof(f), sizeof(f) * 8);
	getchar();
}