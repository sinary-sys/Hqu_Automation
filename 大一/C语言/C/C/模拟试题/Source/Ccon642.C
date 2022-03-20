#include <stdio.h>
#include <conio.h>
double fun( int n )
{
  double sum = 0.0;
  int /**/ i  /**/;
  for(i=1;i<=n;i++)
     {
	   sum = sum + 1.0 /(2*i+1)/ /**/(2*i+5)    /**/ ;
     }
  return (/**/ sum   /**/);
}

int main()
{  
  printf("fun(53) = %8.3f\n", fun(53));
  getch( );
  return 0;
}


