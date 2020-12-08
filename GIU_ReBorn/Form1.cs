using System;
using System.Net; 
using System.Net.Sockets; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO.Ports;

using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace GIU_ReBorn
{
    public partial class Form1 : Form
    {
        int MeriamAzimuth;
        int MeriamElevation;

        // Data Input from Serial
        public static bool local = false;
        public Int32 numberOfBytesRead = 0;

        private const Int32 bufferSize = 100000;
        private const Int32 timeoutMsec = 2500;


        // Multiport Variable
        private Int32 clientPortSelect = 0;
        private IPAddress ipAddressClientConnect = null;

        private Socket tcpClientSocket = null;
        private IAsyncResult clientSocketConnect = null;
        private IPEndPoint clientSocketEndPoint = null;

        private Thread threadClientSide = null;
        private byte[] clientReceiveBuffer = new byte[bufferSize];
        private byte[] clientTransmitBuffer = new byte[bufferSize];

        private bool clientDisconnectCommand = false;
        private bool clientconnectbuttonstate;

        private bool openConnection = false;
        private bool realconnect = false;
        private Int32 totalBytez = 0;
        private Int32 connectioncounter = 0;

        string _clientIPAddress = "192.168.1.33";
        string _clientPort = "11114";
        Int16 buffertick;
        string dataIN1="tes";
        /// <summary>
        ///Handler data queue
        /// </summary>
        Queue<string> dataBuffer = new Queue<string>();

        public Form1()
        {

            InitializeComponent();
            initSerial();

            // Looking to server connection in the first run
            clientOpenConnection(_clientIPAddress, _clientPort);
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = false;

            if (realconnect)
            {
                // Enable Event Handler port 1
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            }
            // Enable Event Handler port 2
            //serialPort2.DataReceived += new SerialDataReceivedEventHandler(serialPort2_DataReceived);
        }
        /// <summary>
        /// Algoritma pemrosesan Queue pada GIU
        /// </summary>
        /// 
        private void processQueue(string output)
        {
             if (dataBuffer.Count > 0)
            {
                output = dataBuffer.Dequeue();
                //datatoTCP = output;
                //Pemilihan metode pemrosesan data antrian sistem
                try //Penambahan try catch agar system tidak error saat gagal
                {
                    if (output.Substring(0, 2).CompareTo("S1") == 0)
                    {
                        parsingSerial(output.Substring(2, output.Length - 2), 1);
                    }
                    else if (output.Substring(0, 2).CompareTo("F") == 0)
                    {
                        ///FCSPROCESS, FOR NOW ONLY WRITE IT TO MERIAM
                       serialPort1.WriteLine(output.Substring(1, output.Length-1));
                        //processFCS(output);
                    }
                }
                catch
                {
                    return;
                }   
            }
        }
        private void processFCS(string command)
        {
            try
            {
                if (command.Substring(0,4).CompareTo("*GM1#") == 0)
                {
                    serialPort1.WriteLine("*GM1#");
                }
                    /*
                else if (command.Substring(0,3).CompareTo("*GF")//(komando gerakan)
                     * {
                     *      
                     * }
                     */
            }
            catch
            {
                return;
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            processQueue(dataIN1);
            //serialPort1.WriteLine("woii apa kabar");
        }
        private void initSerial()
        {

            try
            {
                serialPort1.Close();
                serialPort2.Close();

                serialPort1.PortName = "COM1";
                serialPort1.BaudRate = 9600;
                serialPort1.ReadTimeout = 2000;
                serialPort1.Open();
                //serialPort1.WriteBufferSize = 1000;
               
            }
            catch (Exception)
            {
                DialogResult dialogresult = MessageBox.Show("No Serial port detected!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
            }

        }

        private void Form1_Closed(object sender, EventArgs e)
        {
            // Close All client connections (close all client connection)
            //threadClientSide.Abort();
            clientCloseConnection();
            serialPort1.Close();
            serialPort2.Close();
            
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string dataSerialIn = serialPort1.ReadExisting();

                if (dataSerialIn.Length != 0)
                {
                    ///
                    /// Dicomment agar tidak membebani sistem dengan thread baru, dialihkan ke queue
                    ///
                    //this.Invoke((System.Threading.ThreadStart)delegate
                    //{
                    //    textBox4.Text = dataSerialIn;
                    //    parsingSerial(dataSerialIn, 1);
                    //    dataIN1 = dataSerialIn; //Baru
                    //    // Console.WriteLine(dataSerialIn);
                    //    { }
                    //});

                    dataBuffer.Enqueue("S1" + dataSerialIn);
                }
            }
            catch
            {
                return;
                //MessageBox.Show("Could not read COM Port");
            }

        }

        private void parsingSerial(string data, int serialNo)
        {
            /** Parsing serial can be one of this input:
             * BCC, LRF, RADAR, CO-PROC, OPTDIR
             * 
             * **/

            // Input Serial received
            if (serialNo == 1)
            {
                textBox3.Text = data;
            }
            else
            {
                textBox5.Text = data;
            }
            sendToFCS(data);
            //if (data == "data azimuth & elevasi")

            ///ASUMSI FORMAT SELALU *GY,XXX,ZZZ)
            ///KALAU DATA KEGESER DKK AKAN GAGAL, PERLU ALGORITMA PARSING LEBIH MUTAKHIR
            ///UPDATE 29/11/2020 2.39 AM -> GAGAL. DISARANKAN LANGSUNG LEMPAR APAPUN DARI KOPRO KE FCS

            //if ((data[0] == '*') && (data[1] == 'G') && (data[2] == 'Y'))
            //{
            //    MeriamAzimuth = Convert.ToInt32(data.Substring(4,3));
            //    MeriamElevation = Convert.ToInt32(data.Substring(8,3));
            //    showAzimutElevation(MeriamAzimuth, MeriamElevation);
            //}
            //else
            //{
            //    { }
            //}

        }

        private void showAzimutElevation(int azimuth, int elevation)
        {
            // data azimuth & elevasi dari Meriam
            //textBox1.Text = "data azimuth";
            //textBox2.Text = "data elevasi";
            textBox1.Text = azimuth.ToString();
            textBox2.Text = elevation.ToString();

            string dataAE = azimuth.ToString() + ' ' + elevation.ToString();
            sendToFCS(dataAE);
        }

        private void sendToFCS(string data)
        {
            Int32 totalNumberOfBytes = 0;
            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            // clientSentBytes.Text = null;
            totalNumberOfBytes = data.Length;
            encoding.GetBytes(data, 0, totalNumberOfBytes, clientTransmitBuffer, 0);
            try
            {
                tcpClientSocket.Send(clientTransmitBuffer, totalNumberOfBytes, SocketFlags.None);       ///< Sends data.
                realconnect = true;
                totalBytez = 1;
            }
            catch
            {
                //Biar bisa jadi metode kroscek apakah tersambung / tidak
                clientReceivedBytes.Text = "Fail";
                totalBytez = 0;
                realconnect = false;
                return;
            }
            // clientSentBytes.Text = Convert.ToString(totalNumberOfBytes);
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            // ReCalling client open connection if it's failed
            openConnection = clientSocketConnect.AsyncWaitHandle.WaitOne(timeoutMsec, false);
            if (openConnection == false)
            {

                //clientCloseConnection();
                clientOpenConnection(_clientIPAddress, _clientPort);
            }
            if (realconnect)
            {
                // Enable Event Handler port 1
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            }
            counterNetwork.Text = connectioncounter.ToString();
        }

        /// <summary>
        /// Pengecekan koneksi server apakah benar-benar terkoneksi atau tidak
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            if ((totalBytez == 0) || (openConnection == false))
            {
                if (connectioncounter < 3)
                {
                    connectioncounter++;
                    serialPort1.DataReceived -= new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                    //Mekanisme reset connection counter
                    try
                    {
                        sendToFCS("a");
                    }
                    catch
                    {
                        return;
                    }
                }
                else
                {
                    clientConnectionDetails.Text = "Masala";
                    //if (!realconnect)
                    //{
                    //    // Enable Event Handler port 1
                    //    serialPort1.DataReceived -= new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                    //}
                    clientCloseConnection();
                    clientOpenConnection(_clientIPAddress, _clientPort);
                    connectioncounter = 0;
                }
            }
            else if (dataBuffer.Count > 0) //Mengirimkan hanya saat tidak ada antrian
            {
                connectioncounter = 0;
                //sendToFCS("a");
                try
                {
                    sendToFCS(dataIN1);
                }
                catch
                {
                    sendToFCS("a");
                }
            }
            buffertick++;
            if (buffertick > 2)
            {
                serialPort1.DiscardInBuffer();
                buffertick = 0;
            }
        }

        bool ValidateIPAddress(string ipAddress)
        {
            char fullStop = '.';
            string[] octetBytes = null;
            int octetValue = 0;
            int loopCount = 0;
            octetBytes = ipAddress.Split(fullStop);
            /// Checks number of octets in IP address.
            if (octetBytes.Length != 4)
            {
                return false;
            }
            try
            {
                /// Checks maximum octet value i.e. 255.
                for (loopCount = 0; loopCount < 4; loopCount++)
                {
                    octetValue = Convert.ToInt32(octetBytes[loopCount]);
                    if (octetValue < 0 || octetValue > 255)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void clientOpenConnection(string _clientIPAddress, string _clientPort)
        {
            openConnection = false;
            LingerOption lingeroption = null;
            string clientIPTemp; // FCS IP Address
            string clientPortTemp;

            if (string.IsNullOrEmpty(clientIP.Text))
            {
                clientIPTemp = _clientIPAddress;
            }
            else 
            {
                clientIPTemp = clientIP.Text;                
            }

            if (string.IsNullOrEmpty(clientPort.Text))
            {
                clientPortTemp = _clientPort;
            }
            else
            {
                clientPortTemp = clientPort.Text;
            }

            if (clientconnectbuttonstate == false) // (clientConnectButton.Text == "Connect")
            {
                if (ValidateIPAddress(clientIPTemp) == false)
                {
                    clientConnectionDetails.Text = "Enter valid IP address";
                    return;
                }

                try
                {
                    ipAddressClientConnect = IPAddress.Parse(clientIPTemp);      ///< Checks for valid IP.
                }
                catch
                {
                    clientConnectionDetails.Text = "Enter valid IP address";
                    return;
                }

                try
                {
                    // Checks if port number is valid.
                    clientPortSelect = (Int32)Convert.ToUInt32(clientPortTemp);
                    if ((clientPortSelect > 65535) || (clientPortSelect < 1))
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch
                {
                    clientConnectionDetails.Text = "Port number must be positive value less than 65535.";
                    return;
                }
                clientConnectionDetails.Text = "Trying to connect...";
                clientConnectButton.Text = "Trying...";
                clientConnectButton.Enabled = false;
                clientPort.Enabled = false;
                clientIP.Enabled = false;
                try
                {
                    clientSocketEndPoint = new IPEndPoint(ipAddressClientConnect, clientPortSelect);
                    tcpClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    lingeroption = new LingerOption(false, 0);
                    tcpClientSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Linger, lingeroption);
                    tcpClientSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.DontLinger, false);
                    clientSocketConnect = tcpClientSocket.BeginConnect(clientSocketEndPoint, null, null);
                    /// Sets time-out for BeginConnect procedure.
                    openConnection = clientSocketConnect.AsyncWaitHandle.WaitOne(timeoutMsec, false);
                    if (openConnection == false)
                    {
                        clientConnectionDetails.Text = "Timeout.";
                        tcpClientSocket.Close();
                    }
                }
                catch (SocketException exception)
                {
                    clientConnectionDetails.Text = "Failed. Socket error Code = " + (exception.ErrorCode).ToString();
                }
                catch
                {
                    clientConnectionDetails.Text = "Failed. Unable to connect.";
                }
                clientConnectButton.Enabled = true;
                if (openConnection == false)
                {
                    tcpClientSocket = null;
                    clientConnectButton.Text = "Connect";
                    clientPort.Enabled = true;
                    clientIP.Enabled = true;
                    //tambahan
                    totalBytez = 0;
                    return;
                }
                clientConnectButton.Text = "Disconnect";
                clientConnectionDetails.Text = "Connected.";
                clientSendButton.Enabled = true;
                /// New thread to watch reception of data and connectivity.
                threadClientSide = new Thread(() => ClientReceiveProcedure(tcpClientSocket));
                threadClientSide.Start();
                clientDisconnectCommand = false;
                clientconnectbuttonstate = true;
            }
        }

        private void clientCloseConnection()
        {
            clientDisconnectCommand = true;
            try
            {
                tcpClientSocket.Shutdown(SocketShutdown.Both);      ///< Stops Send/Receive immediately.
                Thread.Sleep(50);
                tcpClientSocket.Close();                            ///< Closes the socket.
            }
            catch
            {
                clientConnectionDetails.Text = "No connection exists.";
            }
            threadClientSide = null;
            tcpClientSocket = null;
            clientSocketEndPoint = null;
            clientConnectButton.Text = "Connect";
            clientConnectionDetails.Text = "Disconnected.";
            clientSendButton.Enabled = false;
            //clientSentBytes.Text = "0";
            //clientReceivedBytes.Text = "Empty";
            clientPort.Enabled = true;
            clientIP.Enabled = true;
            clientconnectbuttonstate = false;
        }

        /// <summary>
        /// Prosedur untuk menerima data dari server sebagai client
        /// 
        /// </summary>
        /// <param name="clientSocket"></param>
        private void ClientReceiveProcedure(Socket clientSocket)
        {
            Int32 totalBytesReceived = 0;
            string totalBytesStringFormat = null;
            string dataReceivedStringFormat = null;
            while (true)
            {
                
              
                try
                {
                    /// Receives over asynchronous socket.
                    totalBytesReceived = clientSocket.Receive(clientReceiveBuffer, bufferSize, SocketFlags.None);
                    
                    totalBytez = totalBytesReceived;
                    if (totalBytesReceived >= 30000)
                    {
                        clientReceiveBuffer = null;
                        totalBytesReceived = 0;
                        totalBytez = totalBytesReceived;
                    }
                }

                catch
                {
                    totalBytez = 0;
                    UpdateClientFormControls("Fail", null, false);
                    break;
                }
                if (clientDisconnectCommand == true)
                {
                    UpdateClientFormControls("Fail", null, true);
                    totalBytez = 0;
                    //realconnect = false;
                    break;
                }
                if (totalBytesReceived == 0)
                {
                    UpdateClientFormControls("Empty", null, true);
                    totalBytez = 0;
                    //realconnect = false;
                    break;
                }
                else
                {
                    realconnect = true;
                }
                
               // totalBytesRecBox.Text = totalBytesReceived.ToString();
                totalBytesStringFormat = totalBytesReceived.ToString();
                dataReceivedStringFormat = Encoding.UTF8.GetString(clientReceiveBuffer, 0, totalBytesReceived);
                //Memasukkan data dari FCS ke Buffer
                dataBuffer.Enqueue("F" + dataReceivedStringFormat);
                UpdateClientFormControls(totalBytesStringFormat, dataReceivedStringFormat, false);
            }
        }

        /// Procedure to update the form controls from other thread.
        private void UpdateClientFormControls(string totalBytes, string dataReceived, bool clientConnect)
        {
            object sender = null;
            if (InvokeRequired)
            {
                this.Invoke(new Action<string, string, bool>(UpdateClientFormControls), new object[] { totalBytes, dataReceived, clientConnect });
                return;
            }
            //Algoritma pelemparan data yang didapat ke serial
            textBox3.Text = dataReceived;
            //if (openConnection)
            //{
            //    serialPort1.WriteLine(dataReceived);
            //}
            //clientReceivedBytes.Text = totalBytes;
            //
            // Console.WriteLine(dataReceived);
            receivedDataClient.Text = dataReceived;           
            //serialPort1.WriteLine(dataReceived);
            receivedDataClient.SelectionStart = receivedDataClient.Text.Length;
            //totalBytesRecBox.Text = realconnect.ToString();
            //totalBytesRecBox.Text = totalBytez.ToString();
            if (totalBytez == 0)
            {
                realconnect = false;
            }
            realConnectBox.Text = realconnect.ToString();
            receivedDataClient.ScrollToCaret();
            if (clientConnect == true)
            {
                clientConnectButton_Click(sender, EventArgs.Empty);
            }
        }

        private void clientConnectButton_Click(object sender, EventArgs e)
        {
            clientCloseConnection();
            clientOpenConnection(_clientIPAddress, _clientPort);
        }

        
        private void clientSendButton_Click(object sender, EventArgs e)
        {
            sendToFCS(clientDataToSend.Text);
        }


    }
}
