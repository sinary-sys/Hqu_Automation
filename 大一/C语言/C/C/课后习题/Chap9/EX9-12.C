#include <stdio.h>
int length(char *str)
{
	int n=0;
	while (*str++) n++;
	return n;
}
void main(void) {
	printf("%d\n",length("Hello the world"));
}