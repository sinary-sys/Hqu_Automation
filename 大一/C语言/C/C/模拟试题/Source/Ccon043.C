#include <stdio.h>
void main()
{
  int min_val(int arr[][4],int *row,int *col);
  int a[3][4]={{3,5,7,8},{4,2,1,9},{16,23,19,12}};
  int i=0,j=0,min,*row,*col;
  row=&i;
  col=&j;
  min=min_val(/**/a   /**/,row,col);
  printf(" Min value is %d\n Row is %d,Col is %d\n",min,*row,*col);
  getch();
}

int min_val(int arr[][4],int *row,int *col)
{
  int i,j,min;
  min=arr[0][0];
  *row=0;
  *col=0;
  for(i=0;i<3;i++)
   for(j=0;j<4;j++)
    {if(arr[i][j]<min)
	   {/**/min=arr[i][j];                 /**/
        *row=i;
        *col=j;
       }
    }
  return(/**/min     /**/);
}
