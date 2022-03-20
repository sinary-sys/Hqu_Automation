#include <stdio.h>
#include <conio.h>
#define N 10
void fun(int a[N+1],int x)
{ /**/

	int i;
	for (i=N-1;i>=0;i--)
		a[i+1]=a[i];
	a[0]=x;

 /**/
}

int main()
{
  int a[N+1]={-5,23,16,18,33,21,8,6,4,10},x,i;
  printf("Input x:");
  scanf("%d",&x);
  printf("Array a:\n");
  for(i=0;i<N;i++) printf("%d ",a[i]);
  fun(a,x);
  printf("\nArray a:\n");
  for(i=0;i<N+1;i++) printf("%d ",a[i]);
  printf("\n");
  getch();
  return 0;
}
