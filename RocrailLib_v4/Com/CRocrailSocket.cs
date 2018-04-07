using System.Net.Sockets;

namespace RocrailLib_v4
{
    public class CRocrailSocket
    {
        private Socket m_socket;

        public CRocrailSocket(string hostname, int port)
        {
            this.m_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.m_socket.Connect(hostname, port);
        }

        /// <summary>
        /// Envoie une trame au serveur rocrail, nécessite de créer le header
        /// </summary>
        /// <param name="trame"></param>
        public void Send(byte[] trame)
        {
            this.m_socket.Send(trame);
        }

        /// <summary>
        /// Permet d'attrendre que des données soit disponible sur le buffer TCP
        /// </summary>
        private void _waitData()
        {
            this.Peek(new byte[1], 0, 1);
        }

        /// <summary>
        /// Lit toutes les données disponibles sur le buffer TCP
        /// </summary>
        /// <returns></returns>
        public byte[] ReadAll()
        {
            byte[] _buffer;

            this._waitData();

            _buffer = new byte[this.m_socket.Available];
            this.Peek(_buffer, 0, _buffer.Length, SocketFlags.None); 

            return _buffer;
        }

        /// <summary>
        /// Lit les données sur le buffer TCP
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="offset"></param>
        /// <param name="size"></param>
        public void Read(byte[] buffer, int offset, int size)
        {
            this._waitData();

            this.Peek(buffer, offset, size, SocketFlags.None);
        }

        /// <summary>
        /// Lit les données sur le serveur TCP sans les retirer
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="offset"></param>
        /// <param name="size"></param>
        /// <param name="socketFlags"></param>
        private void Peek(byte[] buffer, int offset, int size, SocketFlags socketFlags = SocketFlags.Peek)
        {
            int _bytesToRead = size;
            int _read;

            _read = offset;

            while (_bytesToRead > 0)
            {
                int _toRead = (_bytesToRead > this.m_socket.ReceiveBufferSize) ? this.m_socket.ReceiveBufferSize : _bytesToRead;

                int _readed = this.m_socket.Receive(buffer, _read, _toRead, socketFlags);
                _read += _readed;
                _bytesToRead -= _readed;
            }
        }

        public void Close()
        {
            this.m_socket.Shutdown(SocketShutdown.Both);
            this.m_socket.Close();
        }
    }
}
