#include <stdio.h>
#include <conio.h>
void fun_time(int x[],int n,/* y */int y)  
{
  int i;
  for(i=0;/* i>n */i<n; i++ )
     x[i]*=y;
}

void main()
{
  int a[10]={12,4,6,9,0,-2,3,10,-6,19};
  int i,k;
  printf("Input a multiplier:");
  scanf("%d",&k);
  fun_time(/* a[1]  */a,10,k);    
  printf("Now array a is:");
  for(i=0;i<10;i++)
     printf("%4d",a[i]);
  printf("\n");
  getch();
}