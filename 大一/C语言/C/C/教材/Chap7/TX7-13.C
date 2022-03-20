#include <stdio.h>
#include <ctype.h>
void main()
{
	char c;
	while ((c=getchar())!='.') {
		if (islower(c)) c=toupper(c);
		else c=tolower(c);
		putchar(c);
	}
}