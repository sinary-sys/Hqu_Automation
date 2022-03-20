#include <stdio.h>
#include <conio.h>
#define N 10
int main()
{	double a[N]={1.1,3.2,5.3,0.4,4.5,6.7,8.8,9.9,10.0,2.2},ave,/* sum1=1 */sum1=0,sum2=0;
	int i;
	for( i=0;/* i<=N */i<N ;i++ )
          sum1+=a[i];
	ave=sum1/N;
	/*  i=1  */i=0 ;
	while( i<N )
	{	sum2+=(a[i]-ave)*(a[i]-ave);
		i++;
	}
	printf("sum2=%.3f\n",sum2);
	getch();
	return 0;
}


