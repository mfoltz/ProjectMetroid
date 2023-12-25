// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_SommelierBarrelFountain_DataServer
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
  public struct Script_SommelierBarrelFountain_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_DelayBetween_Min;
    private static readonly System.IntPtr NativeFieldInfoPtr_DelayBetween_Max;
    private static readonly System.IntPtr NativeFieldInfoPtr_OffsetDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_Timer;
    private static readonly System.IntPtr NativeFieldInfoPtr_CenterPosition;
    [FieldOffset(0)]
    public PrefabGUID SpawnEntity;
    [FieldOffset(4)]
    public float DelayBetween_Min;
    [FieldOffset(8)]
    public float DelayBetween_Max;
    [FieldOffset(12)]
    public float OffsetDistance;
    [FieldOffset(16)]
    public float Timer;
    [FieldOffset(20)]
    public float3 CenterPosition;

    static Script_SommelierBarrelFountain_DataServer()
    {
      Il2CppClassPointerStore<Script_SommelierBarrelFountain_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_SommelierBarrelFountain_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_SommelierBarrelFountain_DataServer>.NativeClassPtr);
      Script_SommelierBarrelFountain_DataServer.NativeFieldInfoPtr_SpawnEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SommelierBarrelFountain_DataServer>.NativeClassPtr, nameof (SpawnEntity));
      Script_SommelierBarrelFountain_DataServer.NativeFieldInfoPtr_DelayBetween_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SommelierBarrelFountain_DataServer>.NativeClassPtr, nameof (DelayBetween_Min));
      Script_SommelierBarrelFountain_DataServer.NativeFieldInfoPtr_DelayBetween_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SommelierBarrelFountain_DataServer>.NativeClassPtr, nameof (DelayBetween_Max));
      Script_SommelierBarrelFountain_DataServer.NativeFieldInfoPtr_OffsetDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SommelierBarrelFountain_DataServer>.NativeClassPtr, nameof (OffsetDistance));
      Script_SommelierBarrelFountain_DataServer.NativeFieldInfoPtr_Timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SommelierBarrelFountain_DataServer>.NativeClassPtr, nameof (Timer));
      Script_SommelierBarrelFountain_DataServer.NativeFieldInfoPtr_CenterPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SommelierBarrelFountain_DataServer>.NativeClassPtr, nameof (CenterPosition));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_SommelierBarrelFountain_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
