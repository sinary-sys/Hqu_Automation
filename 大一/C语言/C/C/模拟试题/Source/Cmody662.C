#include <stdio.h>
#include <conio.h>
#define M 5
#define N 6

float convert_arr(int a[][N])
{ float sum, aver;
  int i,j;
  /* sum=1; */sum=0;
  for(i=0;i<M;i++)
    for(j=0;j<N;j++)
      sum+=a[i][j];
  aver=sum/ /* M*N */(M*N);
  for(i=0;i<M;i++)
    for(j=0;j<N;j++)
      if(a[i][j]>=aver) a[i][j]=1;
	  else a[i][j]=/* 2 */0;
  return aver;
}

int main()
{ int a[M][N] = {{13,24,15,12,8,29},{18,36,7,10,22,6},{23,16,5,28,33,12},{30,25,20,19,11,36},{26,14,37,42,27,25}};
  float ave;
  int i,j;
  printf("Original array: \n");
  for(i=0;i<M;i++)
  {
    for(j=0;j<N;j++) printf("%3d ",a[i][j]);
    printf("\n");
  }
  ave=convert_arr(a );
  printf("Average : %.3f\n",ave);
  printf("Converted array: \n");
  for(i=0;i<M;i++)
  {
    for(j=0;j<N;j++) printf("%3d ",a[i][j]);
    printf("\n");
  }
  getch();
  return 0;
}
