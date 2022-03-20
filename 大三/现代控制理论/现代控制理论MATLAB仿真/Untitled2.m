R=10000*10^-3;%定义电阻r的值
L=3*10^-6;%定义电感L的值
C=5*10^-6;%定义电容c的值
A=[0 1/C;-1/L -R/L];%A矩阵
B=[0 ;1/L];%B矩阵
C=[1 0];%C矩阵
D=[0];
sys=ss(A,B,C,D);%状态空间表达式；
t=0:0.01:1;
step(sys,t);
figure(1);
grid on;
title('单位斜坡响应');
xlabel('时间');
ylabel('振幅');
d=eig(sys);
disp(d);