#include <stdio.h>
#define N 3
void main()
{
  int a[N][N],i,j,sum=0;
  printf("Enter array a:\n");
  for(i=0;i<N;i++)
    for(j=0; j<N ; j++)
    { scanf("%d",&a[i][j]);
	/*  sum+a[i][j];  */
		sum+=a[i][j];
    }
  printf("\nThe average is %f\n", /*  sum/N*N  */(float)sum/(N*N)  );
  getch();
}








