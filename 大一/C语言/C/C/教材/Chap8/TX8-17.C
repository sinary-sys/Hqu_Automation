#include <stdio.h>
unsigned long strtoint(char strnum[20])
{
	int i;
	long result=0l;
	for (i=0;strnum[i];i++)
		result=result*10+strnum[i]-'0';
	return result;
}
void main()
{
	char str[20];
	printf("Input a digit string: ");
	scanf("%s",str);
	printf("The result is %lu\n",strtoint(str));
}