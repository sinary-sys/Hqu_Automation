#include <stdio.h>
long int fun(long int n)
{
 long int s;
 if(/**/ n==1     /**/)
   s=1;
 else
   s=n*n+/**/fun(n-1)         /**/;
 return (s);
}

void main()
{
 long int n;
 printf("Input n:");
 scanf("%ld",&n);
 if(/**/ n<1    /**/ || n>30)
   printf("%ld is error!\n",n);
 else
   printf("Sum=%ld\n",fun(n));
 getch();
}
