#include <stdio.h>
#include <conio.h>

int main()
{ int i,n=0;
  for(i=1; i<=100; /* i+=2 */i++)
	if(/* i%3==0 */i%3==2)
    {
        printf("%5d",i);
        n++;
		if(n%7==/* 1 */0)  printf("\n");
     } 
  getch();
  return 0;
}