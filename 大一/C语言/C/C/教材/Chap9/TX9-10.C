#include <stdio.h>
void syntax_error(int);
void main(void) {
	int err_num;
	printf("Input a number beyond 0-3 to stop\n");
	for (;;) {
		printf("Input an error code (0-3): ");
		scanf("%d",&err_num);
		if (err_num<0 || err_num>3) break;
		syntax_error(err_num);
	}
}
void syntax_error(int num) {
	char *err[]={
		"cannot open file\n",
		"read error\n",
		"write error\n",
		"media failure\n"
	};
	printf("Reason of error: %s\n",err[num]);
}