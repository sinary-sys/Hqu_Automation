#include <string.h>
#include <conio.h>
#include <math.h>
#include <stdio.h>
#define M 50
double fun(int n)
{ double y = 0.0;
  int i,j;
  j=0;
  for(i=1;;i++)
  {
  /* if((i<10)&&(i%3==0)) */
	if ((i>10)&&(i%3==0))
     {
	 /* y+=1/i; */
		y+=1.0/i;
        j++;
     }
     if(j==n) break;
   }
  return y;
}
void main()
{ clrscr();
  printf("fun(8) = %8.3lf\n", fun(8));
}