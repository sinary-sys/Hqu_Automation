#include <stdio.h>
#include <string.h>
main()
{
  char  str1[128], str2[128];
  int i,len;
  gets(str1);
  len = strlen(str1);
/*   for(i=0; i>len; i++)  */
  for (i=0;i<len;i++)
  {
     if( str1[i] >= '0' && str1[i] <= '8')
         str2[i] = str1[i] + 1;
     else if(str1[i] == '9')
       	 str2[i] = '0';
     else
         str2[i] = str1[i];
  }
/*  str2[i] = '\n';  */
	str2[i]='\0';
  puts(str2);
  getch();
}