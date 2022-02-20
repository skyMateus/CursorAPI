using System;
using System.Runtime.InteropServices;

namespace MouseAPI
{
    public class CursorAPI
    {
        [DllImport("user32.dll", SetLastError = true)]

        //static extern bool SystemParametersInfo(int uiAction, int uiParam, IntPtr pvParam, int fWinIni);

        static extern Boolean SystemParametersInfo(
            UInt32 uiAction,
            UInt32 uiParam,
            IntPtr pvParam,
            UInt32 fWinIni);

        // event
        public const UInt32 MOUSEEVENTF_LEFTDOWN = 0x02;
        public const UInt32 MOUSEEVENTF_LEFTUP = 0x04;

        public const UInt32 MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const UInt32 MOUSEEVENTF_RIGHTUP = 0x10;

        public const UInt32 SPI_SETMOUSESPEED = 0x0071;
        public const UInt32 SPI_GETMOUSESPEED = 0x0070;

        public const UInt32 SPI_GETMOUSECLICKLOCK = 0x101E;
        public const UInt32 SPI_SETMOUSECLICKLOCK = 0x101F;

        public const UInt32 SPI_GETCURSORSHADOW = 0x101A;
        public const UInt32 SPI_SETCURSORSHADOW = 0x101B;

        public const UInt32 SPI_SETMOUSEVANISH = 0x1021;
        public const UInt32 SPI_GETMOUSEVANISH = 0x1020;

        public const UInt32 SPI_SETMOUSESONAR = 0x101D;
        public const UInt32 SPI_GETMOUSESONAR = 0x101C;

        const UInt32 SPI_SETCURSORS = 0x0057;
        const UInt32 SPIF_UPDATEINIFILE = 0x01;
        const UInt32 SPIF_SENDCHANGE = 0x02;

        //Functions

        public int GetMouseCtrlShow()
        {
            return getinfo(SPI_GETMOUSESONAR);
        }
        public void SetMouseCtrlShow(uint yes)
        {
            /* yes - 1 | no - 0 */
            setinfo(SPI_SETMOUSESONAR, (int)yes);
        }

        public int GetMouseVanish()
        {
            return getinfo(SPI_GETMOUSEVANISH);
        }
        public void SetMouseVanish(uint yes)
        {
            /* yes - 1 | no - 0 */
            setinfo(SPI_SETMOUSEVANISH, (int)yes);
        }

        public int GetMouseShadow()
        {
            return getinfo(SPI_GETCURSORSHADOW);
        }
        public void SetMouseShadow(uint yes)
        {
            /* yes - 1 | no - 0 */
            setinfo(SPI_SETCURSORSHADOW, (int)yes);
        }

        public void SetMouseClickLock(uint lock_) 
        {
            /* yes - 1 | no - 0 */
            setinfo(SPI_SETMOUSECLICKLOCK, (int)lock_);
        }
        public int GetMouseClickLock() 
        {
            return getinfo(SPI_GETMOUSECLICKLOCK);
        }

        public int GetMouseSpeed()
        {
            return getinfo(SPI_GETMOUSESPEED);
        }
        public void SetMouseSpeed(uint intSpeed) 
        {
            setinfo(SPI_SETMOUSESPEED, (int)intSpeed);
        }

        // Stock

        private void setinfo(UInt32 SPI_, int value)
        {
            SystemParametersInfo(
              SPI_,
              0,
              (IntPtr)value,
              SPIF_UPDATEINIFILE | SPIF_SENDCHANGE
            );
        }
        private int getinfo(UInt32 SPI_)
        {
            int info = 0;
            IntPtr ptr;
            ptr = Marshal.AllocCoTaskMem(4);
            SystemParametersInfo(SPI_, 0, ptr, 0);
            info = Marshal.ReadInt32(ptr);
            Marshal.FreeCoTaskMem(ptr);
            return info;
        }
    }
}
/*
 
SystemParametersInfo(
                SPI_SETMOUSESPEED, 
                0, 
                uint.Parse(args[0]), 
                0);

    --

mapi mouse = new mapi();

*/
