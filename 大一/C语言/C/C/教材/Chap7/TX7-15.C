#include <stdio.h>
#include <string.h>
void main()
{
	char s1[80],s2[80],s3[80]="Hello the world";
	gets(s1);gets(s2);
	printf("Length of s1 is %d\nLength of s2 is %d\n",strlen(s1),strlen(s2));
	if (strcmp(s1,s2)) printf("The two strings are unequal.\n");
	else printf("The two strings are equal.\n");

	strcat(s1,s2);
	puts(s1);

	strcpy(s1,"New string to s1");
	puts(s1);
	if (strchr(s1,'r')) printf("\'r'\ is in \"%s\"\n",s1);
	if (strstr(s3,"the")) printf("Found \"the\" in string \"%s\"\n",s3);
}