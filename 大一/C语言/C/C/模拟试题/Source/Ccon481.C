#include<stdio.h>
void InsertHead(int a[],int n,int x)
{
   int i;
   for(i=n-1; /**/ i>=0      /**/; i--)
       a[i+1]=a[i];
 /**/a[0]=x;         /**/
}

void main()
{
  int data[11]={1,12,3,14,5,16,7,18,9,10},x,i;
  printf("Pleae input x:");
  scanf("%d",&x);
  InsertHead(/**/data,10,x        /**/);
  for(  i=0;i<11;i++)  printf("%-4d",data[i]);
  printf("\n");
  getch();
}

