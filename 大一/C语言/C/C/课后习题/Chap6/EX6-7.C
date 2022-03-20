#include <stdio.h>
void main()
{
	char c;
	while ((c=getchar())!='\n')
	{
		if ((c>='A' && c<='Z')||(c>='a' && c<='z'))
		{
			if (c=='Z' || c=='z') c-=25;
			else c+=1;
		}
		putchar(c);
	}
}