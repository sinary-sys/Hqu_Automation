#include <stdio.h>
#include <conio.h>
long int  fun(char s[])
{ /**/

	long result=0l;
	int i;
	for (i=0;s[i]!='\0';i++)
		result=result*10+s[i]-'0';
	return result;

 /**/
}

int main()
{
  char s[]="1234";
  printf("The result value is %ld\n",fun(s) );
  getch();
  return 0;
}
