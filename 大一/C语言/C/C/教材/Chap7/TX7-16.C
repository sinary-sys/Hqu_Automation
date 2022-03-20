#include <stdio.h>
void main()
{
	char str1[30],str2[10];
	int i=0,j=0;
	puts("Input string1 and string2: ");
	gets(str1);
	gets(str2);
	while (str1[i]) i++;
	while (str2[j]) str1[i++]=str2[j++];
	str1[i]='\0';
	puts("After the concatenation string1 is: ");
	puts(str1);
}