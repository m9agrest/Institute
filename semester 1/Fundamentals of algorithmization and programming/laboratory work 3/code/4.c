#include <stdio.h>
#include<math.h>
void main() {
	int n = 0;
	int k = 0;
	printf("read N:");
	scanf("%d", &n);
	getchar();

	/*k = ceil(n / 3);
	if (k * 3 == n) {
		k++;
	}*/

	for ( ; k * 3 <= n; k++) {}

	printf("result k:%d", k);
	getchar();
}