#include <stdio.h>
void Sort(int a[],int n,int lastnum)
{/**/
	int i,j,t;
	for (i=n-lastnum;i<n-1;i++)
		for (j=i+1;j<n;j++)
			if (a[i]>a[j])
			{
				t=a[i];
				a[i]=a[j];
				a[j]=t;
			}


 /**/
}
void main()
{
  int a[10]={1,-2,3,-4,5,-6,7,-8,9,-10},i;
  Sort(a,sizeof(a)/sizeof(int),3);
  for( i=0;i<10;i++)
     printf("%d ", a[i]);
  printf("\n");
  getch();
}
