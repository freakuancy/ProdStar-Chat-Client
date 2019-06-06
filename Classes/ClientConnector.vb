Imports System
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Net.Security

Public Class ClientConnector
    ' Member Variables
    Public SERVER_HOST As String = My.Settings.ServerHost
    Public SERVER_PORT As Integer = My.Settings.ServerPort
    Private ClientSocket As Socket
    Private MainNetworkStream As NetworkStream
    Private SSLStreamer As SslStream
    Private MainStreamWriter As StreamWriter
    Private MainStreamReader As StreamReader
    Dim TheMainWindow As MainWindow
    ' Constructor
    Public Sub New(Mainhwnd As MainWindow)
        TheMainWindow = Mainhwnd
    End Sub

    'DoSend method
    Public Sub DoSend(message As String)
        If Not IsNothing(MainStreamWriter) Then
            Try
                If ClientSocket.Connected Then
                    MainStreamWriter.WriteLine(message.Replace(vbNewLine, ""))
                    MainStreamWriter.Flush()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub

    Public Sub DoFlush()
        Try
            MainStreamWriter.Flush()
            MainStreamReader.DiscardBufferedData()
            MainStreamReader.Dispose()
            MainStreamWriter.Dispose()
            MainStreamReader.Close()
            MainStreamWriter.Close()
        Catch ode As System.ObjectDisposedException
            ' // Log if we're in verbose mode.
            If VERBOSE = True Then LogError(Err.ToString)
        Catch ioe As System.IO.IOException
            ' // Log if we're in verbose mode.
            If VERBOSE = True Then LogError(Err.ToString)
        Catch efe As System.Text.EncoderFallbackException
            ' // Log if we're in verbose mode.
            If VERBOSE = True Then LogError(Err.ToString)
        End Try

    End Sub
    'DoConnect method
    Public Sub DoConnect()

        ' Instantiate the socket
        TheMainWindow.Invoke(Sub() WindowPointers.SignOn.Close())
        ClientSocket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        TheMainWindow.Invoke(Sub() WindowPointers.Connection.SetText("Resolving host..."))
        If CancelCon = True Then TheMainWindow.Invoke(Sub() WindowPointers.MainWindow.ClientDisconnected())
        ClientSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, True)
        ServicePointManager.ServerCertificateValidationCallback = New RemoteCertificateValidationCallback(AddressOf AcceptSelf)
        Dim address As IPAddress
        Try

            Dim ipHostInfo As IPHostEntry = Dns.GetHostEntry(SERVER_HOST)

            address = ipHostInfo.AddressList(0)
        Catch Err As SocketException
            TheMainWindow.Invoke(Sub() WindowPointers.Connection.Close())
            LogError(Err.ToString)
            ShowChatMessage(TheMainWindow, Nothing, "ProdStar® - Error", "ProdStar could not resolve the server host. Please check your networking connection and try again.")
            TheMainWindow.Invoke(Sub() TheMainWindow.ClientDisconnected())
        End Try
        ' Try to make the connection
        Dim remoteEP As New IPEndPoint(address, SERVER_PORT)
        TheMainWindow.Invoke(Sub() WindowPointers.Connection.SetText("Connecting to server..."))
        Try
            ClientSocket.Connect(remoteEP)
            MainNetworkStream = New NetworkStream(ClientSocket)
        Catch Err As SocketException
            TheMainWindow.Invoke(Sub() WindowPointers.Connection.Close())
        LogError(Err.ToString)
        ShowChatMessage(TheMainWindow, Nothing, "ProdStar® - Error", "ProdStar could not connect to the remote server. The server may be offline, or you may need to add an exception to your firewall rules.")
        TheMainWindow.Invoke(Sub() TheMainWindow.ClientDisconnected())
        End Try

        If My.Settings.UseSSL = True Then

            SSLStreamer = New SslStream(MainNetworkStream, False, AddressOf AcceptSelf, Nothing)
            Try
                SSLStreamer.AuthenticateAsClient(SERVER_HOST)
            Catch ex As System.Security.Authentication.AuthenticationException
                TheMainWindow.Invoke(Sub() WindowPointers.Connection.Close())
                LogError(Err.ToString)

            End Try
            MainStreamWriter = New StreamWriter(SSLStreamer)
            MainStreamReader = New StreamReader(SSLStreamer)
        Else
            MainStreamWriter = New StreamWriter(MainNetworkStream)
            MainStreamReader = New StreamReader(MainNetworkStream)
        End If

        If CancelCon = True Then TheMainWindow.Invoke(Sub() WindowPointers.MainWindow.ClientDisconnected())

    End Sub
    Public Function AcceptSelf(ByVal sender As Object, ByVal certification As System.Security.Cryptography.X509Certificates.X509Certificate, ByVal chain As System.Security.Cryptography.X509Certificates.X509Chain, ByVal sslPolicyErrors As System.Net.Security.SslPolicyErrors) As Boolean



        If VERBOSE = True Then
            LogConnection("SSL Certificate Transaction: " + vbNewLine + certification.ToString + ", " + sslPolicyErrors.ToString)
        End If
        '       
        If My.Settings.AcceptUntrusted = True Then
            Return True
        Else
            If sslPolicyErrors = sslPolicyErrors.RemoteCertificateNameMismatch Or sslPolicyErrors = sslPolicyErrors.RemoteCertificateNotAvailable Then
                MsgBox("Untrusted Certificate Not Allowed: " + vbNewLine + vbNewLine + sslPolicyErrors.ToString)
            End If
            TheMainWindow.Invoke(Sub() TheMainWindow.ClientDisconnected())
            Return False
        End If

    End Function
    'Getter for the socket
    Public Function GetClientSocket() As Socket
        Return ClientSocket
    End Function
    Public Function IsConnected() As Boolean
        Try
            Return Not (ClientSocket.Poll(100, SelectMode.SelectRead) AndAlso ClientSocket.Available = 0)
        Catch Err As SocketException
            If VERBOSE = True Then LogError(Err.ToString)
            If VERBOSE = True Then LogConnection("Disconnecting Unexpectedly! - " + Err.ToString)
            Return False
        End Try
    End Function

    'DoReceive Method
    Public Function DoReceive() As String
        Dim result As String
        If IsConnected() = True And CancelCon <> True Then
            ' Buffer to hold the results
            Try
                ' Attempt to read
                Dim text As String = ""
                result = MainStreamReader.ReadLine()
            Catch Err As IOException
                ' // Generates Error on Thread Kill, not logging
                '  LogError(Err.ToString)
                result = ""
            End Try
        Else
            result = ""
        End If
        Return result
    End Function

End Class
