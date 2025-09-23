using System;

namespace KI_VEP
{
	public interface IVEPBenchZone
	{
		bool IsChanged { get; }
		void ResetChangedState();
		ushort[] ToRegisters();
		void FromRegisters(ushort[] registers);
	}
}
