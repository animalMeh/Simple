using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class TV
    {
        private Channel[] Channels;
        public Channel CurrentChannel;
        public string Provider { get; private set; }

        public TV(string _provider , params Channel[] _pep)
        {
            Provider = _provider;
            AddChanels(_pep);
            CurrentChannel = Channels[0];
        }


        public  void AddChanels(params Channel[] _pep)
        {
            int i = 0;
            Channels = new Channel[_pep.Count()];
            foreach(Channel c in _pep)
            {
                Channels[i++] = c;
            }
        }
        
        public void NextChannel()
        {
            if (CurrentChannel == Channels[Channels.GetLength(0) - 1])
            {
                CurrentChannel = Channels[0];
                return;
            }
            for (int i = 0; i < Channels.GetLength(0) - 1; i++ )
            {
               
                if (CurrentChannel.Equals(Channels[i]))
                {
                    CurrentChannel = Channels[i + 1];
                    return;
                }   
             }
        }
        public void PreviousChannel()
        {
            if (CurrentChannel == Channels[0])
            {
                CurrentChannel = Channels[Channels.GetLength(0) - 1];
                return;
            }

            for (int i = 1; i < Channels.GetLength(0) ; i++)
            {
               
                if (CurrentChannel.Equals(Channels[i]))
                {
                    CurrentChannel = Channels[i - 1];
                    return;
                }
            }
        }
        public void GoToChannel(int Number)
        {
            if (CurrentChannel.Number.Equals(Number)) return;
            foreach (Channel ch in Channels)
                if (ch.Number.Equals(Number))
                    CurrentChannel = ch;
        }

    }
    class Channel
    {
        public Channel(string _name , int _num)
        {
            Name = _name;
            Number = _num;
        }
        public string Name
        {
            get;set;
        }
        public int Number
        { get; set; }
    }
}
