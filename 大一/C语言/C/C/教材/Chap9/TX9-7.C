#include <stdio.h>
void main(void) {
	int A[3][4]={{1,2,3,4},{5,6,7,8},{9,10,11,12}},i,j;
	i=j=0;
	for (i=0;i<3;i++) {
		for (j=0;j<4;j++) printf("&A[%d][%d]=%-8p",i,j,&A[i][j]);
		printf("\n");
	}
	printf("\n&A[0][0]=%p\n",&A[0][0]);
	printf("A[0]=%p\n",A[0]);
	printf("A=%p\n",A);

	printf("\nThe size of A=%d\n",sizeof(A));
	printf("The size of A[0]=%d\n",sizeof(A[0]));
	printf("The size of A[0][0]=%d\n",sizeof(A[0][0]));
}