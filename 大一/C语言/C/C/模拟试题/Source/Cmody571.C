#include <stdio.h>
#include <conio.h>
void chg_str(/*  s[] */char s[])
{
 int i;
 for(i=0;s[i]!='\0';i++)
   {if ((/* s[i]>='a' */s[i]>='A' && s[i]<='Z' ) && i%2) 
    /* s[i]=s[i]-32;  */s[i]=s[i]+32;
    }       
}

void main(void)
{
  char str_s[100];
  printf("Enter string: ");
  gets(str_s);  
  chg_str(str_s);
  printf("\nNow string is:");
  puts(str_s);  
  getch();
}
