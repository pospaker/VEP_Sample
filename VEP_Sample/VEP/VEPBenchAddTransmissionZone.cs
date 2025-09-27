
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KI_VEP
{
	public class VEPBenchAddTransmissionZone : IVEPBenchZone
	{
		private static VEPBenchAddTransmissionZone _instance;
		private static readonly object _lock = new object();

		private char[] _charBuffer;
		private int _dataSize = 0;
		public string DataString { get; private set; }
		public static VEPBenchAddTransmissionZone Instance
		{
			get
			{
				if (_instance == null)
				{
					lock (_lock)
					{
						if (_instance == null)
							_instance = new VEPBenchAddTransmissionZone();
					}
				}
				return _instance;
			}
		}


		private ushort[] _values;
		public int Size => _values.Length;

		public int this[int index]
		{
			get
			{
				if (index < 0 || index >= _values.Length)
					throw new IndexOutOfRangeException("Index out of range for VEPBenchSynchro values.");

				return _values[index];
			}
			set
			{
				if (index < 0 || index >= _values.Length)
					throw new IndexOutOfRangeException("Index out of range for VEPBenchSynchro values.");

				_values[index] = (ushort)value;
			}
		}


		private bool _isChanged;
		public bool IsChanged => _isChanged;

		public void ResetChangedState()
		{
			_isChanged = false;
		}

		public VEPBenchAddTransmissionZone(int size = 10)
		{
			_values = new ushort[size];
			ResetAllValues();
			_isChanged = false;
		}


		public void FromRegisters(ushort[] registers)
		{

			if (registers == null)
				throw new ArgumentNullException(nameof(registers));

			bool changed = false;

			if (_values.Length != registers.Length)
			{
				
				_values = new ushort[registers.Length];
				changed = true;
			}

			for (int i = 0; i < registers.Length; i++)
			{
				if (_values[i] != registers[i])
				{
					_values[i] = registers[i];
					changed = true;
				}
			}

			//Data를 String으로 만들어 놓는다.
			{
				int startIndex = 1;

				int length = _values[startIndex] & 0x00FF;  // 문자열 길이 (Low Byte)
				_dataSize = length;

				int charPos = 0;

				// 첫 글자 (High Byte of startIndex)
				byte firstChar = (byte)((_values[startIndex] >> 8) & 0x00FF);
				if (firstChar != 0) _charBuffer[charPos++] = (char)firstChar;

				// 나머지 문자들
				for (int i = 1; i < length; i++)
				{
					ushort value = _values[startIndex + i];
					byte low = (byte)(value & 0x00FF);
					byte high = (byte)((value >> 8) & 0x00FF);

					if (low != 0) _charBuffer[charPos++] = (char)low;
					if (high != 0) _charBuffer[charPos++] = (char)high;
				}

				// 버퍼가 부족하면 늘리기
				if (_charBuffer.Length < charPos) _charBuffer = new char[charPos];

				DataString = new string(_charBuffer, 0, charPos);
			}

			if (changed)
			{
				_isChanged = true;
			}
		}

		public ushort[] ToRegisters()
		{
			ushort[] result = new ushort[_values.Length];

			for (int i = 0; i < _values.Length; i++)
			{
				result[i] = Convert.ToUInt16(_values[i]);
			}

			return result;
		}

		public void ResetAllValues()
		{
			for (int i = 0; i < _values.Length; i++)
			{
				_values[i] = 0;
			}
		}

		public void SetValue(int index, ushort value)
		{
			this[index] = value;
		}

		public int GetValue(int index)
		{
			return this[index];
		}

		public void ShowData()
		{
			for (int i = 0; i < _values.Length; i++)
			{
				Console.WriteLine("POS : " + i.ToString() + " VALUE + " + _values[i].ToString());
			}
		}

		public void SetSize(int size)
		{
			if (size <= 0) return;
			_values = new ushort[size];
			for (int i = 0; i < _values.Length; i++)
			{
				_values[i] = 0;
			}
			_charBuffer = new char[size];
		}
	}
}
