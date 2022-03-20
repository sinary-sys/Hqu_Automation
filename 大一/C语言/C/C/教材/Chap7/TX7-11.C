#include <stdio.h>
void main()
{
	int from[4][5],to[20],i,j,k=0;
	printf("Input the elements of the matrix: \n");
	for (i=0;i<4;i++)
		for (j=0;j<5;j++)
		{
			scanf("%d",&from[i][j]);
			to[k++]=from[i][j];
		}
	for (k=0;k<20;k++) printf("%4d",to[k]);
}