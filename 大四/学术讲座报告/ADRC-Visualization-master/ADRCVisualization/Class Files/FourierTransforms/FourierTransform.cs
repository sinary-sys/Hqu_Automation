using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using FFTWSharp;

namespace ADRCVisualization.Class_Files
{
    static class FourierTransform
    {
        public static double FourierMemory { get; } = 100;
        private static fftwf fftwf;

        /// <summary>
        /// Calculates the fourier transform using a wrapper of the 
        /// Fastest Fourier Transform in the West written in objective C.
        /// </summary>
        /// <param name="data">The range of data to be calculated in the fourier transform.</param>
        /// <returns>Returns the non-windowed output of the complex numbers in the FT</returns>
        public static float[] CalculateFFTW(float[] data)
        {
            IntPtr fplan1, pin, pout;
            float[] fin, fout;
            int n;

            n = data.Length;

            fftwf = new fftwf();

            pin = fftwf.malloc(n * 8);
            pout = fftwf.malloc(n * 8);
            fin = new float[n];
            fout = new float[n];

            fplan1 = fftwf.dft_r2c_1d(n, pin, pout, fftw_flags.Estimate);

            fin = data;//for (int i = 0; i < n * 2; i++) fin[i] = (float)Math.Sin(i * Math.PI / 180);// i % 5;
            fout = data;//for (int i = 0; i < n * 2; i++) fout[i] = (float)Math.Sin(i * Math.PI / 180);// i % 5;

            Marshal.Copy(fin, 0, pin, n);
            Marshal.Copy(fout, 0, pout, n);

            fftwf.execute(fplan1);

            Marshal.Copy(pout, fout, 0, n);

            fftwf.free(pin);
            fftwf.free(pout);
            fftwf.destroy_plan(fplan1);

            return fout;
        }
    }
}
