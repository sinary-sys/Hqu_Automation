#include<stdio.h>
#define N 6
void main()
{
 int /* a[N,N] */a[N][N],i,j;
 for(i=0;i<N;i++)
    for(j=0;j<N;j++)
       a[i][j]=i+j*2+5;
 printf("\nArray a is:\n");
 for(i=0;i<N;i++)
   {
    for(j=0;j<N;j++)
       printf("%3d ",a[i][j]);
    printf("\n");
    }
  for(i=0;i<N;i++)
/*  for(j=0; j<N ;j++) */
	for (j=0;j<=i;j++)
        a[i][j]*=3;
  for(i=0;i<N;i++)
/*  for( j=0;j<N;j++) */
	for (j=i+1;i<N;j++)
       a[i][j]-=5;
  printf("\nArray a is turned:\n");
  for(i=0;i<N;i++)
    {
     for(j=0;j<N;j++)
       printf("%3d ",a[i][j]);
     printf("\n");
    }
  getch();
}