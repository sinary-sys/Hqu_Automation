#include <stdio.h>
void main()
{
	char c,nu,nl,nd,no;
	nu=nl=nd=no=0;
	while ((c=getchar())!='\n')
	{
		if (c>='A' && c<='Z') nu++;
		else if (c>='a' && c<='z') nl++;
		else if (c>='0' && c<='9') nd++;
		else no++;
	}
	printf("There are %d uppercase letters.\n",nu);
	printf("There are %d lowercase letters.\n",nl);
	printf("There are %d digits.\n",nd);
	printf("There are %d other characters.\n",no);
}