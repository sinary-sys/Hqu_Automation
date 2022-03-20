#include <stdio.h>
void main(void) {
	char s[]="Huaqiao University";
	char * const p=s;
	*p='s';
	printf("p=%s\n",p);
	printf("*p=%c\n",*p);
}