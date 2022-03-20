#include <stdio.h>
#include <conio.h>
/* void fun() */
int fun()
{
  int large,middle,small,n=0;
  clrscr();
  for( large=0;large<=33;large++ )
    for( middle=0;middle<=50;middle++ )
     {
       small = 2*(100-3*large-2*middle);
	   /* if( large+middle+small=100 )  */
	   if (large+middle+small==100)
       {
         n++;
	 printf("%d-->large:%d,middle:%d,small:%d\n",n,large,middle,small);
       }
    }
  return n;
}
void main()
{
  int num;
  num = fun();
  printf("\n There are %d solutions.\n",num);
  getch();
}
