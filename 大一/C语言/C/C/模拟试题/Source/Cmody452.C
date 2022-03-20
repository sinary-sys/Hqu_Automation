#include <stdio.h>
#include <string.h>
void main()
{
 int i,j,k,position=0;
 char str1[100],str2[100];
 printf("Input Main String:");
 gets(str1);
 printf("Input Sub String:");
 /* str2=gets() */gets(str2) ;
 for(i=0; /* str1[i]='\0' */str1[i]!='\0'; i++)
  {
   for(j=i,k=0; (str1[j]==str2[k])&&(str1[j]!='\0'); j++,k++ )
      ;
   if(str2[k]=='\0')
     {
      position=i+1;
	  /* continue */break;
     }
  }
 printf("\nIt's at:%d\n",position);
 getch();
}