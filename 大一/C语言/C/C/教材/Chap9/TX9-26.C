#include <stdio.h>
#include <stdlib.h>
#define N 5
void main(void) {
	int *Array1D,i;
	Array1D=(int *)malloc(N*sizeof(int));

	for (i=0;i<N;i++) Array1D[i]=i+1;

	printf("\nThe Array1D:\n");
	printf("The address of elements: \n");
	for (i=0;i<N;i++) printf("%p\n",Array1D+i);

	printf("\n\nThe contents of elements: \n");
	for (i=0;i<N;i++) printf("%-3d",Array1D[i]);
	printf("\n");
	free(Array1D);
}