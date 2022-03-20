#include <stdio.h>
#include <stdlib.h>
long fact(int n)
{
	long result=1l;
	int i;
	for (i=2;i<=n;i++)
		result*=i;
	return result;
}
void main(int argc, char *argv[])
{
	int n;
	if (argc!=2) printf("Wrong number of parameters!\n");
	else {
		n=atoi(argv[1]);
		printf("%d!=%ld\n",n,fact(n));
	}
}