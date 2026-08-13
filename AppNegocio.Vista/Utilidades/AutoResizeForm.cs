using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNegocio.Vista.Utilidades
{  
    public class AutoResizeForm
    {
        private Size originalFormSize;
        private Dictionary<Control, Rectangle> controlBounds = new Dictionary<Control, Rectangle>();

        // Guarda el tamaño original del formulario y los bounds de todos sus controles
        public void EscalarFormulario(Form form)
        {
            originalFormSize = form.Size;
            GuardarBounds(form.Controls);
        }

        // Recorre todos los controles (incluyendo hijos anidados) y guarda sus bounds originales
        private void GuardarBounds(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                controlBounds[ctrl] = ctrl.Bounds;
                if (ctrl.HasChildren)
                {
                    GuardarBounds(ctrl.Controls);
                }
            }
        }

        // Calcula la proporción de escalado (X e Y) según el tamaño actual vs el original
        public void RedimensionarFormulario(Form form)
        {
            float xRatio = (float)form.Width / originalFormSize.Width;
            float yRatio = (float)form.Height / originalFormSize.Height;
            Redimensionar(form.Controls, xRatio, yRatio);
        }

        // Reubica y redimensiona cada control multiplicando su posición y tamaño originales por las proporciones
        private void Redimensionar(Control.ControlCollection controls, float xRatio, float yRatio)
        {
            foreach (Control ctrl in controls)
            {
                Rectangle original = controlBounds[ctrl];
                ctrl.SetBounds(
                    (int)(original.X * xRatio),
                    (int)(original.Y * yRatio),
                    (int)(original.Width * xRatio),
                    (int)(original.Height * yRatio)
                );

                if (ctrl.HasChildren)
                {
                    Redimensionar(ctrl.Controls, xRatio, yRatio); 
                }
            }
        }


    }
}
