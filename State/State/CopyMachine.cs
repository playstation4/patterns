﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State.States;

namespace State
{
    public class CopyMachine
    {
        public IState State { get; set; }
        public IDevice CurrentDevice;
        public IDocument CurrentDocument;

        public CopyMachine()
        {
            State = new InitState();
        }

        public void PutMoney()
        {
            State.PutMoney(this);
        }

        public void ChooseDevice()
        {
            State.ChooseDevice(this);
        }

        public void ChooseDocument()
        {
            State.ChooseDocument(this);
        }

        public void Print()
        {
            State.Print(this);
        }

        public void Stop()
        {
            State.Stop(this);
        }
    }

    public interface IDevice
    {
        IDocument GetDocument(string name);
    }

    public interface IDocument
    {
        string ReadInfo();
    }
}
