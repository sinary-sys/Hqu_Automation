#include <stdio.h>
#include <conio.h>
#include <string.h>
#define M 100

void invert_str(char a[ ],int x)
{	int /**/i   /**/;
	printf("Now invert string is:");
	for(i=x-1; i>=0; /**/i--    /**/)
		printf("%c",a[i]);
	printf("\n");
}

int main()
{	char str[M];
	int n;
	printf("Please input string :");
	gets(str);
	n=strlen(/**/str    /**/);
	invert_str(str,n);
	getch();
	return 0;
}

