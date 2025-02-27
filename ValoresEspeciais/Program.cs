using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            byte bmax = byte.MaxValue;
            byte bmin = byte.MinValue;
            Console.WriteLine($"byte máximo: {bmax}");
            Console.WriteLine($"byte mínimo: {bmin}");
            sbyte smax = sbyte.MaxValue;
            sbyte smin = sbyte.MinValue;
            Console.WriteLine($"sbyte máximo: {smax}");
            Console.WriteLine($"sbyte mínimo: {smin}");
            short smaxShort = short.MaxValue;
            short sminShort = short.MinValue;
            Console.WriteLine($"short máximo: {smaxShort}");
            Console.WriteLine($"short mínimo: {sminShort}");
            ushort smaxUpper = ushort.MaxValue;
            ushort sminUpper = ushort.MinValue;
            Console.WriteLine($"ushort máximo: {smaxUpper}");
            Console.WriteLine($"ushort mínimo: {sminUpper}");
            int imax = int.MaxValue;
            int imin = int.MinValue;
            Console.WriteLine($"int máximo: {imax}");
            Console.WriteLine($"int mínimo: {imin}");
            uint umax = uint.MaxValue;
            uint umin = uint.MinValue;
            Console.WriteLine($"uint máximo: {umax}");
            uint overflow_umax = unchecked(uint.MaxValue + 1);
            Console.WriteLine($"uint máx + 1 overflow: {overflow_umax}");
            Console.WriteLine($"uint mínimo: {umin}");
            long lmax = long.MaxValue;
            long lmin = long.MinValue;
            Console.WriteLine($"long máximo: {lmax}");
            Console.WriteLine($"long mínimo: {lmin}");
            ulong ulmax = ulong.MaxValue;
            ulong ulmin = ulong.MinValue;
            Console.WriteLine($"ulong máximo: {ulmax}");
            Console.WriteLine($"ulong mínimo: {ulmin}");
            char cmax = char.MaxValue;
            char cmin = char.MinValue;
            Console.WriteLine($"char máximo: {cmax}");
            Console.WriteLine($"char mínimo: {cmin}");
            float fmax = float.MaxValue;
            float fmin = float.MinValue;
            float overflowFloat = fmax * 10.0f;
            float overflowInfinity = fmax * fmax;
            float underflowFloat = fmin / 1000000.0f;
            Console.WriteLine($"float máximo: {fmax:F3}");
            Console.WriteLine($"float máx * 10.0f overflow: {overflowFloat:F3}");
            Console.WriteLine($"float máx * máx overflow: {overflowInfinity:F3}");
            Console.WriteLine($"float mínimo: {fmin:F3}");
            Console.WriteLine($"float mínimo / 1000000.0f underflow: {underflowFloat:F3}");
            double dmax = double.MaxValue;
            double dmin = double.MinValue;
            Console.WriteLine($"double máximo: {dmax:F3}");
            Console.WriteLine($"double mínimo: {dmin:F3}");
            decimal dmmax = decimal.MaxValue;
            decimal dmmin = decimal.MinValue;
            Console.WriteLine($"decimal máximo: {dmmax:F3}");
            Console.WriteLine($"decimal mínimo: {dmmin:F3}");

            float fminfinite = float.NegativeInfinity;
            float fmaxinfinite = float.PositiveInfinity;
            float fnan = float.NaN;
            Console.WriteLine($"float mínimo infinito: {fminfinite}");
            Console.WriteLine($"float máximo infinito: {fmaxinfinite}");
            Console.WriteLine($"float NaN: {fnan}");

            double dminfinite = double.NegativeInfinity;
            double dmaxinfinite = double.PositiveInfinity;
            double dnan = double.NaN;
            Console.WriteLine($"double mínimo infinito: {dminfinite}");
            Console.WriteLine($"double máximo infinito: {dmaxinfinite}");
            Console.WriteLine($"double NaN: {dnan}");
        }
    }
}
