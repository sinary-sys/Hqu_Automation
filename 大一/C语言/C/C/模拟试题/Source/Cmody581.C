#include <stdio.h>
#include <conio.h>
void main()
{  
   char str[100];
   char *p;
   int count;
   /* count=1; */count=0;
   /* p=str[0]; */p=str;
   scanf("%s",p);
   while ( *p!='\0' )
   {   if(/* p>=0 */*p>='0' && *p <= '9')
         count++;
	    p++; 
   }
   printf("%5d ",count);   
   getch();
}
