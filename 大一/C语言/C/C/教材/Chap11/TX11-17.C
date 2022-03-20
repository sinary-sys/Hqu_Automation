#include <stdio.h>
void main(void) {
	enum weekday {sun,mon,tur,wed,thu,fri,sat};
	char *rs[]={"Sun","Mon","Tur","Wed","Thu","Fri","Sat"};
	enum weekday wd;
	int day;
	printf("Input the day you wanna to know(0-6): [ ]\b\b");
	scanf("%d",&day);
	wd=(enum weekday)day;
	printf("%s\n",rs[wd]);
}