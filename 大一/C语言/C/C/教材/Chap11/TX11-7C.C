#include <stdio.h>

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
struct employee *AddressMaxEid(struct employee emp[],int n);
void main(void) {
	struct employee *pmax=AddressMaxEid(emp,sizeof(emp)/sizeof(struct employee));
	printf("MaxEid=%d\n",pmax->EId);
}

struct employee *AddressMaxEid(struct employee emp[],int n)
{
	int i=0;
	struct employee *pmax=emp;
	for (i=0;i<n;i++)
		if (emp[i].EId>pmax->EId) pmax=emp+i;
	return pmax;
}