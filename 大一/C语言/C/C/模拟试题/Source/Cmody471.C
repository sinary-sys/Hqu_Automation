#include<stdio.h>
#define N 10
void main()
{
  int a[N],i,j,t;
  printf("Input a:");
  for( i=0;i<N;i++)
	 scanf("%d",/* a[i] */&a[i]);
  for (i=0,j=N-1;i<j;i++,j--)
  /*
    t=a[i]; a[i]=a[j]; a[j]=t;
  */
	{t=a[i];a[i]=a[j];a[j]=t;}
  for( i=0;i<N;i++)
     printf("%d ",*(a+i) );
  getch();
}









