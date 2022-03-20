#include <stdio.h>
#define N 10
void main()
{
	int i,data[N];
	printf("Input ten integers: ");
	for (i=0;i<N;i++)
	{
		scanf("%d",&data[i]);
		if (data[i]>0) printf("%4d",data[i]);
	}
	printf("\n");
}