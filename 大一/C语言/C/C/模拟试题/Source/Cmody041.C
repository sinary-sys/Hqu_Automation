#include <stdio.h>
#include <string.h>
main()
{
  char  str1[128];
  /*  int i,len; sum=0; */
  int i,len,sum=0;
  printf("\nPlease input the string: ");
  gets(str1);
  len = strlen(str1);
  for(i=0; i<len; i++)
  {
   /* if( str1[i] >= '0' || str1[i] <= '9') */
	  if (str1[i] >= '0' && str1[i] <= '9')
          sum++;
  }
  printf("%d\n",sum);
  getch();
}
