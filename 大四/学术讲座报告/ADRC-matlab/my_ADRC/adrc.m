function adrc()
    %���д���
    round_time = 5000;
    %����
    step = 5;
    %ʱ��
    ts = 0.01;
    %��������
    r = 10;
    %�˲�����
    h0 = 0.1;
    %λ��
    pos = 1:1:round_time;
    %ʱ����
    times = pos*ts;
    %��0
    beta_01 = 100;
    beta_02 = 300;
    beta_03 = 1000;
    z1 = zeros(1,round_time);
    z2 = zeros(1,round_time);
    z3 = zeros(1,round_time);
    input = zeros(1,round_time);
    output = zeros(1,round_time);
    sys=tf(1,[1,10,5]);  %�������ض��󴫵ݺ���
    %sys=tf(1,[1,2]);  %�������ض��󴫵ݺ���
    dsys = c2d(sys,ts,'z')
    [num,den] = tfdata(dsys,'v');
    input = sin(times)+rand(1,round_time)/100;
    
end





