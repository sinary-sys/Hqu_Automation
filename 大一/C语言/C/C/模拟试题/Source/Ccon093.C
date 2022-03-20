#include<stdio.h>
long fib(int n);
void main()
{
 int k;
 clrscr();
 printf("The first 15 data of Fibonacci is:\n\n");
 for(k=1;k<=15;k++)
   printf("%d ",fib(k));
 printf("\n");
 getch();
}

long fib(int n)
{
  if(n==1||n==2)
	/**/return 1;              /**/
  else
	return /**/fib(n-1)+fib(n-2)                       /**/;
}