// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_SommelierHorizontalBarrels_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_SommelierHorizontalBarrels_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Amount;
    private static readonly System.IntPtr NativeFieldInfoPtr_Waves;
    private static readonly System.IntPtr NativeFieldInfoPtr_Spacing;
    private static readonly System.IntPtr NativeFieldInfoPtr_DelayBetweenWaves;
    private static readonly System.IntPtr NativeFieldInfoPtr_DelayBetween_Min;
    private static readonly System.IntPtr NativeFieldInfoPtr_DelayBetween_Max;
    private static readonly System.IntPtr NativeFieldInfoPtr_RoomSizeOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_Timer;
    private static readonly System.IntPtr NativeFieldInfoPtr_WaveTimer;
    private static readonly System.IntPtr NativeFieldInfoPtr_CenterPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_Direction;
    [FieldOffset(0)]
    public PrefabGUID SpawnEntity;
    [FieldOffset(4)]
    public int Amount;
    [FieldOffset(8)]
    public int Waves;
    [FieldOffset(12)]
    public float Spacing;
    [FieldOffset(16)]
    public float DelayBetweenWaves;
    [FieldOffset(20)]
    public float DelayBetween_Min;
    [FieldOffset(24)]
    public float DelayBetween_Max;
    [FieldOffset(28)]
    public float RoomSizeOffset;
    [FieldOffset(32)]
    public float Timer;
    [FieldOffset(36)]
    public float WaveTimer;
    [FieldOffset(40)]
    public float3 CenterPosition;
    [FieldOffset(52)]
    public float3 Direction;

    static Script_SommelierHorizontalBarrels_DataServer()
    {
      Il2CppClassPointerStore<Script_SommelierHorizontalBarrels_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_SommelierHorizontalBarrels_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels_DataServer>.NativeClassPtr);
      Script_SommelierHorizontalBarrels_DataServer.NativeFieldInfoPtr_SpawnEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels_DataServer>.NativeClassPtr, nameof (SpawnEntity));
      Script_SommelierHorizontalBarrels_DataServer.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels_DataServer>.NativeClassPtr, nameof (Amount));
      Script_SommelierHorizontalBarrels_DataServer.NativeFieldInfoPtr_Waves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels_DataServer>.NativeClassPtr, nameof (Waves));
      Script_SommelierHorizontalBarrels_DataServer.NativeFieldInfoPtr_Spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels_DataServer>.NativeClassPtr, nameof (Spacing));
      Script_SommelierHorizontalBarrels_DataServer.NativeFieldInfoPtr_DelayBetweenWaves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels_DataServer>.NativeClassPtr, nameof (DelayBetweenWaves));
      Script_SommelierHorizontalBarrels_DataServer.NativeFieldInfoPtr_DelayBetween_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels_DataServer>.NativeClassPtr, nameof (DelayBetween_Min));
      Script_SommelierHorizontalBarrels_DataServer.NativeFieldInfoPtr_DelayBetween_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels_DataServer>.NativeClassPtr, nameof (DelayBetween_Max));
      Script_SommelierHorizontalBarrels_DataServer.NativeFieldInfoPtr_RoomSizeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels_DataServer>.NativeClassPtr, nameof (RoomSizeOffset));
      Script_SommelierHorizontalBarrels_DataServer.NativeFieldInfoPtr_Timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels_DataServer>.NativeClassPtr, nameof (Timer));
      Script_SommelierHorizontalBarrels_DataServer.NativeFieldInfoPtr_WaveTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels_DataServer>.NativeClassPtr, nameof (WaveTimer));
      Script_SommelierHorizontalBarrels_DataServer.NativeFieldInfoPtr_CenterPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels_DataServer>.NativeClassPtr, nameof (CenterPosition));
      Script_SommelierHorizontalBarrels_DataServer.NativeFieldInfoPtr_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels_DataServer>.NativeClassPtr, nameof (Direction));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
