#include <stdio.h>
#include <conio.h>
int fun( char *p )
{
 int y;
 /* y=1; */ y=0;
 while(*p!='\0')
   {y=y*2+*p-'0';
 /* y++ */p++;
   }
 return(/**/ y /**/);
}

void main()
{
 char str_b[9];
 printf("Enter binary string: ");
 gets(str_b);  
 printf("\nDecimal is: %d\n",fun(str_b) ); 
 getch();
}