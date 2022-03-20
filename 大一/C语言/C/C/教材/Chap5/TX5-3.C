#include <stdio.h>
void main()
{
	char c;
	c=getchar();
	if (c>='0' && c<='9') printf("%c is a digit.\n",c);
	else if (c>='A'&& c<='Z') printf("%c is an uppercase letter.\n",c);
	else if (c>='a' && c<='z') printf("%c is a lowercase letter.\n",c);
	else printf("%c is other character.\n",c);
}