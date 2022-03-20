#include <stdio.h>
void info(const char name[20],const int age)
{
	printf("name: %s,age: %d\n",name,age);
}
void main()
{
	const char yourname[20]="David Beckham";
	const int age=18;
	info(yourname,age);
}