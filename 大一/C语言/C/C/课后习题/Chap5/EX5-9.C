#include <stdio.h>
void main()
{
	char c;
	c=getchar();
	if (c>='A' && c<='Z') c+=32;
	putchar(c);
	putchar('\n');
}