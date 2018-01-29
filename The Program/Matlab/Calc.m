clc, clear all; close all;
%%%%%   First Voltage divider  %%%%%
Vin1 = 220 ; %%% Voltage to the transformer
Vout1 = 5 ;  %%% Voltage to the Arduino for reading 
% Formula for Vout = Vin(R2/(R1+R2))
Vratio_1 = Vout1/Vin1; % Finding the ration between Vout and Vin
% R2 = ((Vout/Vin)*R1)/((Vout/Vin)-1)
R1_1 = [1e6, 1.2e6, 1.5e6, 1.8e6, 2.2e6...
      2.7e6 ,3.3e6,3.9e6,3.9e6,4.7e6...
      5.6e6, 6.8e6, 8.2e6, 10e6, 12e6 ...
      15e6, 18e6, 22e6];
L_R1 = length(R1_1);
R2_1 = zeros(L_R1,1);
Iin_1 = zeros(L_R1,1);
for r = 1:L_R1
R2_1(r) = abs((Vratio_1*R1_1(r))/(Vratio_1-1));
Iin_1(r) = Vin1/R1_1(r);
end

%%%% Second Voltage Devider %%%%
Vin2 = 24; % Voltage from the transformer
Vout2 = 5; % Voltage to the arduino
% Formula for Vout = Vin(R2/(R1+R2))
Vratio_2 = Vout2/Vin2; % Finding the ration between Vout and Vin
% R2 = ((Vout/Vin)*R1)/((Vout/Vin)-1)
L_R1 = length(R1_1);
R2_2 = zeros(L_R1,1);
Iin_2 = zeros(L_R1,1);
for r = 1:L_R1
R2_2(r) = abs((Vratio_2*R1_1(r))/(Vratio_2-1));
Iin_2(r) = Vin2/R1_1(r);
end


%%% calculation
% Vin = 220;
% R1 = 5400000;
% R2 = 110000;
% disp('Votlage divider one')
% Vout = Vin*((R2)/(R1+R2))
% I = Vin/R1


VIn = 24;
R11 = 2700000;
R21 = 660000;
VOut = VIn*(R21/(R21+R11))
R2_Ch = abs(((24/5)*R11)/((24/5)-1))
II = VIn/R11



