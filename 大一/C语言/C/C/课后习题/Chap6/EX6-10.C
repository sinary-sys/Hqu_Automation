#include <stdio.h>
void main()
{
	int eggs;
	for (eggs=5;eggs%2!=1||eggs%3!=2||eggs%4!=3;eggs+=5);
	printf("eggs=%d\n",eggs);
}