# QuantumComputingPOC
 A small repository to experiment with and learn the basics of Q# programming language
 
 This solution has two projects under it. Host is a C# console Application which is meant to call the underlying Q# project.
 
 QSharpPOC, as the name suggests is the file where you'll find all the different Q# snippets. 
 Library.qs is the stub code from Microsoft's documentation (found here) [https://docs.microsoft.com/en-us/quantum/]
 
## Implemented 
 
 ### Quantum Entanglement
 
 - An input Qubit is put into super-position using the Hadermad Operation. Using this as the control qubit, a CNOT operation is applied to anouther qubit to put them entangle them.
 - These two entangled bits are then measured to get their values. Since these qubits are entangled, both bits should have the same value.
 - Since the QDK is just emulating a quantum machine on our conventional machine, we have a 100% accuracy (both qubits have same value). However, it is important to note that due to noise, the results will often be a little inaccurate on present day NISQ (Noisy Intermediate Scale Quantum) Machine.
 
## Currently Working on:
 
 ### Quantum Random Number Generation
 
 - On a conventional computer, a Random Number generator can generate a pseudo-random number at best.
 - Quantum number do not have this limitation as they can put their qubits in a state of superposition. Thus, they are equally likely to be either 0 or 1 when measured.
 - We are using this principle to generate a Random Number.

I hope you find this interesting. I would be excited to collaborate on a new use case/project, if you have something in mind XD

All the best!
