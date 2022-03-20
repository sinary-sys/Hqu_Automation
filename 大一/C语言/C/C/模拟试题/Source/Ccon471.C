#include <stdio.h>
int CountNumber(unsigned long n)
{
  /**/int counter;     /**/ counter= 0 ;
  if(n==0 || n>4000000000) return 0;
  while(n){
	n/=/**/ 10    /**/;
    counter++;
  }
  return  counter;
}

void main()
{
  unsigned long  x;
  printf("Pleae input x(x>0 and x<=4000000000:");
  scanf("%lu",&x);
  printf("The total number of digits is %d.\n", /**/ CountNumber(x)             /**/);
  getch();
}


