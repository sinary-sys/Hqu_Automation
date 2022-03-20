#include <stdio.h>
#include <string.h>
main()
{
  char  s1[100], s2[100];
  int i,s_len;
  printf("Please input string: \n");   
  gets(s1);
  s_len = strlen(s1);
  for(/**/i=1; /**/ i<s_len;  i++)
  {
     if( s1[i] >= '1' && s1[i] <= '9')
         /**/s2[i]--;/**/ 
     else if(  /**/ s1[i] =0/**/)
       	 s2[i] = s1[i]+9; 
	 else
         s2[i] = s1[i]; 
  }
       s2[i] = '\0';  
  puts(s2);
  getch();
}