﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Logger
{
    public enum MessageType
    {
        INFO = 1,       //   1
        WARNING = 2,    //  10
        ERROR = 3,      // 100
        ALL = 7         // 111
    }

    public abstract class AbstractLogger //obradjivac
    {
        protected MessageType messageTypeHandling;
        protected AbstractLogger nextLogger;
        public AbstractLogger(MessageType messageType)
        { 
            this.messageTypeHandling = messageType; 
        }
        public void SetNextLogger(AbstractLogger logger)
        {
            this.nextLogger = logger;
        }
        public void Log(string message, MessageType type)
        {
            if((type & this.messageTypeHandling) != 0)
            {
                this.WriteMessage(message, type);
            }
            if(this.nextLogger != null)
            {
                this.nextLogger.Log(message, type);
            }
        }
        protected abstract void WriteMessage(string message, MessageType type);
    }
}
