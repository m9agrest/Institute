#include <stdio.h>

void main() {
	int a[40] = {
			-70, -31, 95, 58, 88,
			-3, -62, 84, -57, 5,
			41, -52, 84, -11, 90,
			27, -45, 87, 26, 68,
			-40, 80, -78, -9, 46,
			-62, -29, 93, 97, 63,
			62, 63, 49, 82, 13,
			-34, 95, -98, 81, 34
	};
	int max = a[0];
	int maxi = 0;
	int min = a[0];
	int mini = 0;
	for (int i = 0; i < 40; i++) {
		if (a[i]>max) {
			max = a[i];
			maxi = i;
		}
		if (a[i] < min) {
			min = a[i];
			mini = i;
		}
	}
	int result = 0;

	int in = mini + 1;
	int n = maxi;
	if (maxi < mini) {
		in = maxi + 1;
		n = mini;
	}
	for (int i = in; i <= n; i++) {
		result += a[i];
	}
	printf("result: %d", result);
	getchar();
}