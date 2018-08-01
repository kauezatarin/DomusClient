﻿using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using DomusClient.Properties;

namespace DomusClient
{
    public static class ServerHandler
    {
        public static string serverIp { get; private set; }

        public static int serverPort { get; private set; }

        public static TcpClient server { get; private set; }

        public static NetworkStream stream
        {
            get
            {
                try
                {
                    return server.GetStream();
                }
                catch(Exception e)
                {
                    throw e;
                }
            }
        }
        
        /// <summary>
        /// Inicializa o ServerHandler.
        /// </summary>
        public static void Initialize()
        {
            SetConnectionProperties();
            Connect();
        }

        /// <summary>
        /// Carrega os parametros de conexão do arquivo de configurações.
        /// </summary>
        private static void SetConnectionProperties()
        {
            serverIp = Settings.Default.serverIp;
            serverPort = Settings.Default.serverPort;
        }

        /// <summary>
        /// Atualiza os dados de conexão.
        /// </summary>
        public static void UpdateConnectionProperties(string ip, int port = 9090)
        {
            serverIp = ip;
            serverPort = port;
        }

        /// <summary>
        /// Cria um novo objeto TcpClient com uma conexão ativa com o servidor.
        /// </summary>
        public static void Connect()
        {
            server = new TcpClient();

            try
            {
                server.Connect(serverIp, serverPort);
            }
            catch (SocketException e)
            {
                throw e;
            }

        }

        /// <summary>
        /// Envia uma string para o servidor
        /// </summary>
        public static bool ServerWrite(NetworkStream stream, string message, int timeout = -1)
        {
            try
            {
                stream.WriteTimeout = timeout;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
                stream.Write(msg, 0, msg.Length);
                stream.WriteTimeout = -1;

                return true;
            }
            catch
            {
                stream.WriteTimeout = -1;
                return false;
            }
        }

        /// <summary>
        /// Recebe um objeto serializado do servidor.
        /// </summary>
        public static object ServerReadSerilized(NetworkStream stream, int timeout = -1)
        {
            byte[] readMsgLen = new byte[4];
            int dataLen;
            byte[] readMsgData;
            BinaryFormatter bf1 = new BinaryFormatter();
            MemoryStream ms;

            //seta o timeout de leitura dos dados para 30 segundos
            stream.ReadTimeout = timeout;

            //le o tamanho dos dados que serão recebidos
            stream.Read(readMsgLen, 0, 4);
            dataLen = BitConverter.ToInt32(readMsgLen, 0);
            readMsgData = new byte[dataLen];

            //le os dados que estão sendo recebidos
            stream.Read(readMsgData, 0, dataLen);

            ms = new MemoryStream(readMsgData);
            ms.Position = 0;

            //converte os dados recebidos para um objeto
            object objeto = bf1.Deserialize(ms);

            //seta o timeout para o valor padrão (infinito)
            stream.ReadTimeout = -1;

            return objeto;
        }

        /// <summary>
        /// Recebe uma string do servidor.
        /// </summary>
        public static string ServerRead(NetworkStream stream, int timeout = -1)
        {
            Byte[] bytes = new Byte[1024];
            string data = null;
            int i;

            try
            {
                // Loop to receive all the data sent by the client
                while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    // Translate data bytes to a ASCII string.
                    data += System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                }

                return data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// Libera todos os recursos de conexão alocados.
        /// </summary>
        public static void Dispose()
        {
            try
            {
                stream.Dispose();
                server.Close();
                server.Dispose();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
