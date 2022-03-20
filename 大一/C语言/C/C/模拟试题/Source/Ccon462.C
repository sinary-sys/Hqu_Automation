#include <stdio.h>
#include <string.h>
void main()
{
 char str[100],a[20],*p;
 int n=0,i,j;
 int x;
 printf("Input string:");
 gets(str);
 /**/p=str;        /**/
 while(*p!='\0')
   {
	for(i=0; *p>='0' && /**/ *p<='9' /**/; p++)
      {
       a[i]=*p;
       i++;
      }
    if(i>0)
      {
       x=0;
       for(j=0;j<i;j++)
		   x=x*10+a[j]-/**/48     /**/;
       printf("%d+15=%d\n",x,x+15);
       n++;
      }
    if(n==1)
      break;
    else
      p++;
   }
 if(n==0)
   printf("15\n");
 getch( );
}