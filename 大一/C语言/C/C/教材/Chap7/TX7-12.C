#include <stdio.h>
#define N 10
void main()
{
	char name[N];
	int i;
	printf("Input your name: ");
	for (i=0;i<N;i++) scanf("%c",&name[i]);

	printf("Hello ");
	for (i=0;i<N;i++) printf("%c",name[i]);
	printf("\n");
}