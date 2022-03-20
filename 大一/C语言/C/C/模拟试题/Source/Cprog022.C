#include <stdio.h>
char *substr(char s[],int m,int n)
{ static char scut[100];
  /**/

	int i;
	for (i=0;i<n;i++)
		scut[i]=s[i+m];
	scut[i]='\0';






  /**/
  return scut;
}

void main()
{
  char str[ ]="Goodafternoon";
  char *substr(),*p;
  p=substr(str,3,5);
  printf("%s\n",p);
  getch();
}

