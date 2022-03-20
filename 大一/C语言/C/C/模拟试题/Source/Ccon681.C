#include <stdio.h>
#include <conio.h>
int main()
{	char str[100];
	int /**/ i   /**/;
	puts("Please Input a string: ");
	gets(str);
	i=0;
	while(str[i])
	{
		if( str[i] >= '0' && str[i] <= '8')  /**/  str[i]++   /**/ ;
			else  if(/**/str[i]=='9'      /**/ )  str[i]= '0';
		i++;
	}
	puts("The transformed string : ");
	puts(str);
	getch();
	return 0;
}
