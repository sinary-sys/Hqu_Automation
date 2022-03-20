#include <stdio.h>
#include <stdlib.h>
#include <string.h>
void main(int argc,char *argv[])
{
	if (argc!=3) {
		printf("You should type two strings\n");
		exit(1);
	}
	printf("The result is %s\n",strcat(argv[1],argv[2]));
}