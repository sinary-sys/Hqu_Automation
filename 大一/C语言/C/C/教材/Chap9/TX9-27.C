#include <stdio.h>
#include <stdlib.h>
#define M 3
#define N 5
void main(void) {
	int (*Array2D)[N],i,j;
	Array2D=(int(*)[N])malloc(M*sizeof(int[N]));

	for (i=0;i<M;i++)
		for (j=0;j<N;j++)
			Array2D[i][j]=i*10+j;
	printf("\nArray2D: \n");
	for (i=0;i<M;i++)
	{
		for (j=0;j<N;j++)
			printf("%-5d",Array2D[i][j]);
		printf("\n");
	}
	free(Array2D);
}