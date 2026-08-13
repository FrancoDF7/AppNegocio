using System.Runtime.InteropServices;

namespace AppNegocio.Vista.Utilidades
{
    public static class MoverForm
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static void MoverFormulario(IntPtr inte)
        {
            ReleaseCapture();
            SendMessage(inte, 0x112, 0xf012, 0);
        }

    }
}
