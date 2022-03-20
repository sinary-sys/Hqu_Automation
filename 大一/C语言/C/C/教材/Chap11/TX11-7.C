#include <stdio.h>
float average(struct employee *p,int m);
struct employee {
	int EId;
	char name[20];
	char tel[12];
	float salary;
}*pemp,emp[]={	{2015,"John","0595576723",5000.0},
				{2016,"Mike","0595576724",5000.0},
				{2017,"Smith","0595576323",7000.0},
				{2018,"Zoe","0595873291",4000.0},
				{2019,"Evon","0595356723",2500.0},
				{2020,"Svon","0595579757",7000.0},
				{2021,"Hiro","0595579871",8000.0},
				{2022,"Nulin","0595578659",5000.0},
				{2023,"Bacon","0595576812",5000.0},
				{2024,"John","0595965788",5000.0}};
void main(void) {
	float ave;

	pemp=emp;
	ave=average(pemp,10);
	printf("average salary is $%.2f\n",ave);
}

float average(struct employee *p,int m)
{
	int i=0;
	float s=0;
	for (i=0;i<m;i++) s+=(p+i)->salary;
	return s/m;
}