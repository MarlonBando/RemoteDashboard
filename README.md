# RemoteDashboard
This is a simple GUI to visualize the main data on a racing car while it is running.
In the real application there are two Xbee module, one in the car and one outside the car where a guy is connected to it with a usb port,
this guy must have a script that read the data sent to the xbee wich is connected to, and open a socket where all the data are send in order to be visualized by other guy.
RemoteDashboard connects to that socket and from there it obtains all the information it will show on the screen.
To see how it works there is a python script called "DataSimulation.py" that generate random data and send it trough port number 5005.
