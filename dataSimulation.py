import socket
import random
import time

localIP     = "127.0.0.1"

localPort   = 5005

bufferSize  = 1024

data = [0] * 60

UDPServerSocket = socket.socket(family=socket.AF_INET, type=socket.SOCK_DGRAM)

while(True):
    battery_voltage = random.randint(450,600)*10
    soc = ((battery_voltage - 4500) / 1500 * 100)*100
    cellMaxVoltage = random.randint(2500,4200)
    cellMinVoltage = cellMaxVoltage - 50
    CellMaxTemp = random.randint(10,65)*10
    CellMeanTemp = CellMaxTemp - 40
    data[0] = battery_voltage & 255
    data[1] = (battery_voltage >> 8) & 255
    data[2] = cellMaxVoltage & 255
    data[3] = (cellMaxVoltage >> 8) & 255
    data[4] = CellMaxTemp & 255
    data[5] = (CellMaxTemp >> 8) & 255
    data[6] = CellMeanTemp & 255
    data[7] = (CellMeanTemp >> 8) & 255 
    data[8] = cellMinVoltage & 255
    data[9] = (cellMinVoltage >> 8) & 255
    data[10] = int(soc) & 255
    data[11] = (int(soc) >> 8) & 255
    for i in range(12,60):
        data[i] = random.randint(0,255)
    UDPServerSocket.sendto(bytearray(data), (localIP,localPort))
    time.sleep(1)
    print("Send")
