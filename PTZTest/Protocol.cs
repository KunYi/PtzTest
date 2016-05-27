using System;
using System.Collections.Generic;
using System.Text;

namespace PTZTest
{
    abstract class PTZController
    {
        public const byte BIT0 = 0x01;
        public const byte BIT1 = 0x02;
        public const byte BIT2 = 0x04;
        public const byte BIT3 = 0x08;
        public const byte BIT4 = 0x10;
        public const byte BIT5 = 0x20;
        public const byte BIT6 = 0x40;
        public const byte BIT7 = 0x80;

        abstract public byte[] GenerationPacket(Action cmd);
        //abstract public void SendCommand();
    }

    class PelcoD : PTZController
    {
        const byte STX = 0xFF;

        const int posSTX = 0;
        const int posADDRESS = 1;
        const int posCOMMAND1 = 2;
        const int posCOMMAND2 = 3;
        const int posDATA1 = 4;
        const int posDATA2 = 5;
        const int posCHKSUM = 6;

        const byte UP = PTZController.BIT3;
        const byte DOWN = PTZController.BIT4;
        const byte LEFT = PTZController.BIT2;
        const byte RIGHT = PTZController.BIT1;
        const byte WIDE = PTZController.BIT6;
        const byte TELE = PTZController.BIT5;
        const byte NEAR = PTZController.BIT0;
        const byte FAR = PTZController.BIT7;
        // turn on Camera
        const byte MANUAL = PTZController.BIT7 | PTZController.BIT3;
        // turn on Camera and Auto scan
        const byte AUTO = PTZController.BIT7 | PTZController.BIT4 | PTZController.BIT3;

        private byte CalcChksum(byte[] array, int first, int end)
        {
            byte chksum = 0;
            
            for (int i = first; i <= end; i++)
                chksum += array[i];

            return chksum;
        }

        public override byte[] GenerationPacket(Action cmd)
        {
            byte cmd1 = 0, cmd2 = 0;
            byte panSpeed = 0xFF, tiltSpeed = 0xFF;

            byte[] result = new byte[] { STX, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            result[posADDRESS] = cmd.Address;
            // Todo: implement to here
            // Tilt
            if (Action.CSet.UP == (cmd.OP & Action.CSet.UP))
            {
                cmd2 |= UP;
            } else if (Action.CSet.DOWN == (cmd.OP & Action.CSet.DOWN))
            {
                cmd2 |= DOWN;
            }

            // Pan
            if (Action.CSet.LEFT == (cmd.OP & Action.CSet.LEFT))
            {
                cmd2 |= LEFT;
            } else if (Action.CSet.RIGHT == (cmd.OP & Action.CSet.RIGHT))
            {
                cmd2 |= RIGHT;
            }

            // Zoom
            if (Action.CSet.IN == (cmd.OP & Action.CSet.IN))
            {
                cmd2 |= TELE;
            } else if (Action.CSet.OUT == (cmd.OP & Action.CSet.OUT))
            {
                cmd2 |= WIDE;
            }

            // Focus
            if (Action.CSet.NEAR == (cmd.OP & Action.CSet.NEAR))
            {
                cmd1 |= NEAR;
            } else if (Action.CSet.FAR == (cmd.OP & Action.CSet.FAR))
            {
                cmd2 |= FAR;
            }

            if (Action.CSet.STOP == (cmd.OP & Action.CSet.STOP))
            {
                cmd1 = 0;
                cmd2 = 0;
                panSpeed = 0;
                tiltSpeed = 0;
            }
            /*
            if (Action.CSet.AUTO == (cmd.OP & Action.CSet.AUTO))
            {
                cmd1 = AUTO;
            }
            else
            {
                cmd1 = MANUAL;
            }
            */
            result[posCOMMAND1] = cmd1;
            result[posCOMMAND2] = cmd2;
            result[posDATA1] = panSpeed;
            result[posDATA2] = tiltSpeed;
            result[posCHKSUM] = CalcChksum(result, 
                posADDRESS, posDATA2);
            
            return result;
        }
    }

    class PelcoP : PTZController
    {
        const byte STX = 0xA0;
        const byte ETX = 0xAF;

        // position in packet
        const int posSTX = 0;
        const int posADDRESS = 1;
        const int posCOMMAND1 = 2;
        const int posCOMMAND2 = 3;
        const int posDATA3 = 4;
        const int posDATA4 = 5;
        const int posETX = 6;
        const int posCHKSUM = 7;

        // bit fields
        const byte UP = PTZController.BIT3;
        const byte DOWN = PTZController.BIT4;
        const byte LEFT = PTZController.BIT2;
        const byte RIGHT = PTZController.BIT1;
        const byte WIDE = PTZController.BIT6;
        const byte TELE = PTZController.BIT5;
        const byte NEAR = PTZController.BIT1;
        const byte FAR = PTZController.BIT0;
        const byte IRISOPEN = PTZController.BIT2;
        const byte IRISCLOSE = PTZController.BIT3;
        // turn on Camera
        const byte MANUAL = PTZController.BIT6 | PTZController.BIT3;
        // turn on Camera and Auto scan
        const byte AUTO = PTZController.BIT6 | PTZController.BIT5;

        private byte CalcChksum(byte[] array)
        {
            byte chksum = 0;

            for ( int i = 0; i <  array.Length; i++)
                chksum ^= array[i];

            return chksum;
        }

        public override byte[] GenerationPacket(Action cmd)
        {
            byte cmd1 = 0, cmd2 = 0;
            byte panSpeed = 0xFF, tiltSpeed = 0xFf;

            byte[] result = new byte[] { STX, 0x00, 0x00, 0x00, 0x00, 0x00, ETX, 0x00 };

            result[posSTX] = STX;
            result[posADDRESS] = cmd.Address;
            result[posETX] = ETX;

            // Todo: implement to here
            // Tilt
            if (Action.CSet.UP == (cmd.OP & Action.CSet.UP))
            {
                cmd2 |= UP;
            }
            else if (Action.CSet.DOWN == (cmd.OP & Action.CSet.DOWN))
            {
                cmd2 |= DOWN;
            }

            // Pan
            if (Action.CSet.LEFT == (cmd.OP & Action.CSet.LEFT))
            {
                cmd2 |= LEFT;
            }
            else if (Action.CSet.RIGHT == (cmd.OP & Action.CSet.RIGHT))
            {
                cmd2 |= RIGHT;
            }

            // Zoom
            if (Action.CSet.IN == (cmd.OP & Action.CSet.IN))
            {
                cmd2 |= TELE;
            }
            else if (Action.CSet.OUT == (cmd.OP & Action.CSet.OUT))
            {
                cmd2 |= WIDE;
            }

            // Focus
            if (Action.CSet.NEAR == (cmd.OP & Action.CSet.NEAR))
            {
                cmd1 |= NEAR;
            }
            else if (Action.CSet.FAR == (cmd.OP & Action.CSet.FAR))
            {
                cmd1 |= FAR;
            }
            /*
            if (Action.CSet.AUTO == (cmd.OP & Action.CSet.AUTO))
            {
                cmd1 = AUTO;
            }
            else
            {
                cmd1 = MANUAL;
            }
            */
            if (Action.CSet.STOP == (cmd.OP & Action.CSet.STOP))
            {
                cmd1 = 0;
                cmd2 = 0;
            }

            result[posCOMMAND1] = cmd1;
            result[posCOMMAND2] = cmd2;
            result[posDATA3] = panSpeed;
            result[posDATA4] = tiltSpeed;
            result[posCHKSUM] = CalcChksum(result);
            return result;

        }
    }

    class KID312 : PTZController
    {
        // repeate
        const byte cmdAUTO = 0x41;      // 'A'
        const byte cmdSequence = 0x24;  // '$'
        const byte ZoomIn = 0x49;       // 'I'
        const byte ZoomOut = 0x4F;      // 'O'
        const byte FocusNear = 0x4E;    // 'N'
        const byte FocusFar = 0x46;     // 'F'
        const byte TiltUp = 0x55;       // 'U'
        const byte TiltDown = 0x44;     // 'D'
        const byte PanLeft = 0x4C;      // 'L'
        const byte PanRight = 0x52;     // 'R'

        const byte TurnOFF = 0x20;
        const byte chZERO = 0x30;
        const int posCOMMAND = 2;
        const int posS100 = 3;
        const int posS10 = 4;
        const int posS1 = 5;

        public override byte[] GenerationPacket(Action cmd)
        {
            byte[] result = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7E /* '~' */ };

            // PTZ Controller response
            // @, Function, S100, S10, S0


            string strAddress = cmd.Address.ToString();

            if (3 == strAddress.Length)
            {
                result[posS100] = (byte) strAddress[0];
                result[posS10] = (byte) strAddress[1];
                result[posS1] = (byte) strAddress[2];
            }
            else if (2 == strAddress.Length)
            {
                result[posS100] = chZERO;
                result[posS10] = (byte) strAddress[0];
                result[posS1] = (byte) strAddress[1];
            }
            else if (1 == strAddress.Length)
            {
                result[posS100] = chZERO;
                result[posS10] = chZERO;
                result[posS1] = (byte) strAddress[0];
            }

            // Todo: implement to here
            switch (cmd.OP)
            {
                case Action.CSet.UP: // Tile Up
                    result[posCOMMAND] = TiltUp;
                    break;
                case Action.CSet.DOWN: // Tile Down
                    result[posCOMMAND] = TiltDown;
                    break;
                case Action.CSet.LEFT: // Pan Left
                    result[posCOMMAND] = PanLeft;
                    break;
                case Action.CSet.RIGHT: // Pan Right
                    result[posCOMMAND] = PanRight;
                    break;
                case Action.CSet.IN: // Zoom In
                    result[posCOMMAND] = ZoomIn;
                    break;
                case Action.CSet.OUT: // Zoom Out
                    result[posCOMMAND] = ZoomOut;
                    break;
                case Action.CSet.NEAR:   // Focus near
                    result[posCOMMAND] = FocusNear;
                    break;
                case Action.CSet.FAR:    // Focus far
                    result[posCOMMAND] = FocusFar;
                    break;
            }
            return result;
        }
    }

    class YANN : PTZController
    {
        // repeate
        const byte STX = 0x02;
        const int posADDRESS = 1;
        const int posCOMMAND = 2;
        const int posDATA = 3;
        const int posOPDATA = 4;

        public override byte[] GenerationPacket(Action cmd)
        {
            byte[] result = new byte[] { 0x32, 0x04, 0x95 };
            // Todo: implement to here
            switch (cmd.OP)
            {
                case Action.CSet.UP: // Tile Up
                    break;
                case Action.CSet.DOWN: // Tile Down
                    break;
                case Action.CSet.LEFT: // Pan Left
                    break;
                case Action.CSet.RIGHT: // Pan Right
                    break;
                case Action.CSet.IN: // Zoom In
                    break;
                case Action.CSet.OUT: // Zoom Out
                    break;
                case Action.CSet.NEAR:   // Focus near
                    break;
                case Action.CSet.FAR:    // Focus far
                    break;
            }

            return result;
        }
    }

    // repeate command type
    // interval : 200ms.
    // stop receive stop command or prev command > 250ms
    // ADT8060/ CCR-20G
    class CCR20G : PTZController
    {
        const byte STX = 0x40;
        const byte TYPE1 =  0x43;
        const byte TYPE2 = 0x50;

        const int posSTX = 0;
        const int posTYPE = 1; 
        const int posADDRESS = 2;
        const int posCOMMAND = 3;
        const int posCHKSUM = 4;

        public override byte[] GenerationPacket(Action actions)
        {
            byte[] result = new byte[] { STX, 0x00, 0x00, 0x00, 0x00 };
            return result;
        }
    }
}
