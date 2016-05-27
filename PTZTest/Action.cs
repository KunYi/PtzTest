using System;
using System.Collections.Generic;
using System.Text;

namespace PTZTest
{
    class Action
    {
        public enum CSet { NONE = 0, UP = 1, DOWN = 2, LEFT = 4, RIGHT = 8, IN = 16, OUT = 32, NEAR = 64, FAR = 128, AUTO = 256, STOP = 512};
        private readonly CSet m_cmd;
        private readonly byte m_adr;
        private readonly byte m_PanSpeed;
        private readonly byte m_TiltSpeed;

        public CSet OP {
            get { return m_cmd; }
        }

        public byte Address {
            get { return m_adr; }
        }

        public byte PanSpeed
        {
            get { return m_PanSpeed; }
        }

        public byte TiltSpeed
        {
            get { return m_TiltSpeed; }
        }

        public Action(byte address, CSet cmd, byte panspeed, byte tiltspeed) 
        {
            m_adr = address;
            m_cmd = cmd;
            m_PanSpeed = panspeed;
            m_TiltSpeed = tiltspeed;
        }

        public Action(byte address, CSet cmd)
        {
            m_adr = address;
            m_cmd = cmd;
            m_PanSpeed = 0xFF;
            m_TiltSpeed = 0xFF;
        }
    }
}
