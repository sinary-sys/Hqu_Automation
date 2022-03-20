#include <stdio.h>
void print(int,int,int (*f1)(int,int));
int add(int,int);
int max(int,int);
void main(void) {
	int data1=10,data2=34;
	int (*p_fun)(int,int);

	p_fun=add;
	print(data1,data2,p_fun);

	p_fun=max;
	print(data1,data2,p_fun);
}
int add(int i,int j)
{
	return i+j;
}
int max(int i,int j)
{
	return i>j?i:j;
}
void print(int i,int j,int (*f1)(int,int)) {
	printf("%d\n",f1(i,j));
}