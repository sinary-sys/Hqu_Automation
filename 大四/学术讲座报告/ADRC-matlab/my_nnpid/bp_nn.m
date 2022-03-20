classdef bp_nn< handle
    properties
        %ѧϰ��
        learning_rate =  0.1;
        %�����ߴ�
        input_dim = 2;
        %������1�ߴ�
        h1_dim = 4;
        %������2�ߴ�
        %h2_dim = 4;
        %�����ߴ�
        output_dim = 3;
        w_i;
        b_i;
        w_o;
        b_o;
        output;
        h_layer_1;
    end
    methods
        %% ���캯��
        function obj = bp_nn(input_dim,h1_dim,output_dim)
            obj.input_dim = input_dim;
            obj.h1_dim = h1_dim;
            obj.output_dim = output_dim;
            obj.w_i = rand(input_dim,h1_dim)-0.5;
            obj.b_i = rand(1,h1_dim)-0.5;
            obj.w_o = rand(h1_dim,output_dim)-0.5;
            obj.b_o = rand(1,output_dim)-0.5;
            obj.h_layer_1 = zeros(1,h1_dim);
        end
        %% ѵ��
        function train(obj,input,eval)
                obj.forward(input);
                gradient = obj.output-eval;
                gradient
                obj.backward(input,gradient);
                
        end
        %% ǰ�򴫲�
        function forward(obj,input)
            obj.h_layer_1 = obj.neural_networks_forward(input,obj.w_i,obj.b_i,@obj.lrelu);
            obj.output = obj.neural_networks_forward(obj.h_layer_1,obj.w_o,obj.b_o,@obj.lrelu);
        end
        %% ���򴫲�
        function backward(obj,input,gradient)
            [obj.w_o,obj.b_o,last_gradient] = obj.neural_networks_back(obj.learning_rate,obj.h_layer_1,obj.output,obj.w_o,obj.b_o,gradient,@bp_nn.lrelu_gradient);
            [obj.w_i,obj.b_i,~] = obj.neural_networks_back(obj.learning_rate,input,obj.h_layer_1,obj.w_i,obj.b_i,last_gradient,@obj.lrelu_gradient);
        end
    end
    methods(Static)
        %% ǰ�򴫲��������
        function out = neural_networks_forward(input,weights,bias,active_func)
            out_unactive = input*weights+bias;
            out = active_func(out_unactive);
        end
        %% �����󵼵������
        function [weights_new,bias_new,last_gradient] = neural_networks_back(learning_rate,input_layer,out,weights,bias,gradient,active_gradient_func)
            %��ֹ �ݶȱ�ը��
            g_max = max(abs(gradient));
            if g_max>5
                gradient = gradient/g_max*5;
            end
            %�������
            gradient_new = active_gradient_func(out).*gradient;
            %����ƫ��
            bias_new = bias - learning_rate.*gradient_new;
            %weights �ĳߴ� input*output
            [w_h,w_w] = size(weights);
            
            %����ƫ��
            x_t = repmat(input_layer',1,w_w);
            gradient_t = repmat(gradient_new,w_h,1);
            weights_new = weights - learning_rate*gradient_t.*x_t;
            %����һ���ݶ�
            last_gradient = gradient_t.*weights;
            last_gradient = sum(last_gradient,2)';
        end
        %% Leaky relu
        function output = lrelu(x)
            output = x;
            for k=1:1:length(output)
                if output(k) < 0
                    output(k)=0.1*output(k);
                end
            end
        end
        %% Leaky relu gradient
        function gradient = lrelu_gradient(output)
            gradient = ones(1,length(output));
            for k=1:1:length(output)
                if output(k)<0
                    gradient(k) = 0.1;
                end
            end
        end
        %% sigmoid
        function output = sigmoid(x)
            output =1./(1+exp(-x));
        end
        %% sigmoid gradient
        function gradient = sigmoid_gradient(output)
            gradient =output.*(1-output);
        end
    end
        
end