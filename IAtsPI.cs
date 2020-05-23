using System;
using System.Runtime.InteropServices;

public interface IAtsPI
{
	void Load();
	void Dispose();
	void SetVehicleSpec(Spec s);
	void Initialize(int s);
	Hand Elapse(State s, IntPtr Pa, IntPtr So);
	void SetPower(int p);
	void SetBrake(int b);
	void SetReverser(int r);
	void KeyDown(int k);
	void KeyUp(int k);
	void HornBlow(int k);
	void DoorOpen();
	void DoorClose();
	void SetSignal(int s);
	void SetBeaconData(Beacon b);
	uint GetPluginVersion();
}
public class IAtsPIClass
{
	static public uint VersionNum = 0x00020000;
}

/// <summary>車両のスペック</summary>
[StructLayout(LayoutKind.Sequential)]
public struct Spec
{
	/// <summary>ブレーキ段数</summary>
	public int B;
	/// <summary>ノッチ段数</summary>
	public int P;
	/// <summary>ATS確認段数</summary>
	public int A;
	/// <summary>常用最大段数</summary>
	public int J;
	/// <summary>編成車両数</summary>
	public int C;
};
/// <summary>車両の状態</summary>
[StructLayout(LayoutKind.Sequential)]
public struct State
{
	/// <summary>列車位置[m]</summary>
	public double Z;
	/// <summary>列車速度[km/h]</summary>
	public float V;
	/// <summary>0時からの経過時間[ms]</summary>
	public int T;
	/// <summary>BC圧力[kPa]</summary>
	public float BC;
	/// <summary>MR圧力[kPa]</summary>
	public float MR;
	/// <summary>ER圧力[kPa]</summary>
	public float ER;
	/// <summary>BP圧力[kPa]</summary>
	public float BP;
	/// <summary>SAP圧力[kPa]</summary>
	public float SAP;
	/// <summary>電流[A]</summary>
	public float I;
};
/// <summary>車両のハンドル位置</summary>
[StructLayout(LayoutKind.Sequential)]
public struct Hand
{
	/// <summary>ブレーキハンドル位置</summary>
	public int B;
	/// <summary>ノッチハンドル位置</summary>
	public int P;
	/// <summary>レバーサーハンドル位置</summary>
	public int R;
	/// <summary>定速制御状態</summary>
	public int C;
};
/// <summary>Beaconに関する構造体</summary>
[StructLayout(LayoutKind.Sequential)]
public struct Beacon
{
	/// <summary>Beaconの番号</summary>
	public int Num;
	/// <summary>対応する閉塞の現示番号</summary>
	public int Sig;
	/// <summary>対応する閉塞までの距離[m]</summary>
	public float Z;
	/// <summary>Beaconの第三引数の値</summary>
	public int Data;
};


