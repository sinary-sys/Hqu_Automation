#include <stdio.h>
#include <conio.h>
void main()
{ /* int i,sum=9 */int i,sum=0;
  i=9; 
  while(/* sum>1000 */sum<=1000)
     {
      /* sum=+i; */sum+=i;
      i++,i++;
     }
  printf("9+11+13+...+%d=%d\n",i-2,sum);
  getch();
}
