#include <stdio.h>
#define MESSAGE "You are right!\n"
#define LONG_STRING "This is very long string \
that is used as an example\n"
#define ABS(a) (a)<0?-(a):(a)
void main(void)
{
	printf(MESSAGE);
	printf("MESSAGE\n");
	printf(LONG_STRING);
	printf("abs of -1 and 1: %d %d\n",ABS(-1),ABS(1));
}