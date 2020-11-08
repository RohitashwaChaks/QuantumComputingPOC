using System;
using System.Threading.Tasks;
using static System.Diagnostics.Debug;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using Quantum.QSharpPOC;
using Microsoft.Quantum.Measurement;
using Newtonsoft.Json.Serialization;

namespace Host
{
    static partial class Program
    {
        static async Task Main(string[] args)
        {
            await RandomNumberGenerator(50);
            await Entanglement();
        }
        static async Task RandomNumberGenerator(int count)
        {
            using QuantumSimulator sim = new QuantumSimulator();
            {
                await QuatumRandomNumberGenerator(count);
            }
        }
        static async Task Entanglement()
        {
            double eq = 0, count = 10000;
            using QuantumSimulator sim = new QuantumSimulator();
            await HelloQ.Run(sim);
            for(int  i =0; i<count; i++)
            {
                (Result, Result) x = await EntryPoint.Run(sim, 2);
                var val1 = x.Item1;
                var val2 = x.Item2;

                if (val1 == val2)
                    eq++;
            }
            Console.WriteLine($"Quantum Entanglement Testing \n%age Same = {100 * (eq / count)}; %age Different = {100 * (1 -(eq / count))}.");
            //await PrintMessage.Run(sim, input);
        }
    }
}
