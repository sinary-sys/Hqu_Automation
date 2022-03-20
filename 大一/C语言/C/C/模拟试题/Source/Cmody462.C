#include<stdio.h>
#define N 5
void append(int a[N][N],int b[N])
{
 int i,j,k=0,min;
 for(j=0; j<N;/* j+1 */j++)
   {
	/* min=a[0][0] */;
	min=a[0][j];
    for(i=1;i<N;i++)
      if(a[i][j]<min)
         min=a[i][j];
/*  b[k]=a[i][j] */;
	b[k]=min;
    k++;
   }
}
void main()
{
 int a[N][N]={{7,10,5,15,6},{1,4,8,3,9},{12,8,10,3,0},{8,3,9,11,16},{6,12,11,2,10}},b[N];
 int i,j;
 append(a,b);
 printf("Array a :\n");
 for(i=0;i<N;i++)
   {
    for(j=0;j<N;j++)
      printf("%3d ",a[i][j]);
    printf("\n");
   }
 printf("Array b :\n");
 for(i=0;i<N;i++)
   {
    printf("%3d ",b[i]);
   }
 getch();
}