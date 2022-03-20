#include <stdio.h>
#include <string.h>
void main()
{
  char s[100],t[10];
  int i,lenofs;
  puts("Input s:");
  gets(s);
  puts("Input t:");
  gets(t);
  /* i=1; */
  i=0;
  lenofs=strlen(s);
  while(t[i])
  {
    s[lenofs+i]=t[i] ;
    i++;
  }
  s[lenofs+i]=/* '0' */'\0';
  printf("The final string s:%s\n",s);
  getch();
}










