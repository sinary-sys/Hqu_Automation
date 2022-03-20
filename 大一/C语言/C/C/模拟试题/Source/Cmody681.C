#include <stdio.h>
#include <conio.h>
#include <string.h>
int main()
{ char str[100];
  int i,j,len,flag=1;
  printf("Please input a string:");
  gets(str);
  len=strlen(str);
  for(i=0,j=len-1;/**/ i>j /**/; i++,j--)		   
    if( str[i]!=str[j] )
    { flag=0;
      /**/ continue; /**/		
    }
  if(/**/ !flag /**/)   
    printf("The string %s is synmetric!\n",str);
  else  
    printf("The string %s is not synmetric!\n",str);
  getch();
  return 0;
}

