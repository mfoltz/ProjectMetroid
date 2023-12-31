// Decompiled with JetBrains decompiler
// Type: ProjectM.MiscAiGameplayData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MiscAiGameplayData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StationaryWhenIdle;
    private static readonly System.IntPtr NativeFieldInfoPtr_AlertAlliesOnDeath;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoresPathfindingLineOfSight;
    private static readonly System.IntPtr NativeFieldInfoPtr_StopPatrol;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsFleeing;
    [FieldOffset(0)]
    public bool StationaryWhenIdle;
    [FieldOffset(1)]
    public bool AlertAlliesOnDeath;
    [FieldOffset(2)]
    public ModifiableBool IgnoresPathfindingLineOfSight;
    [FieldOffset(6)]
    public ModifiableBool StopPatrol;
    [FieldOffset(10)]
    public bool IsFleeing;

    static MiscAiGameplayData()
    {
      Il2CppClassPointerStore<MiscAiGameplayData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MiscAiGameplayData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiscAiGameplayData>.NativeClassPtr);
      MiscAiGameplayData.NativeFieldInfoPtr_StationaryWhenIdle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscAiGameplayData>.NativeClassPtr, nameof (StationaryWhenIdle));
      MiscAiGameplayData.NativeFieldInfoPtr_AlertAlliesOnDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscAiGameplayData>.NativeClassPtr, nameof (AlertAlliesOnDeath));
      MiscAiGameplayData.NativeFieldInfoPtr_IgnoresPathfindingLineOfSight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscAiGameplayData>.NativeClassPtr, nameof (IgnoresPathfindingLineOfSight));
      MiscAiGameplayData.NativeFieldInfoPtr_StopPatrol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscAiGameplayData>.NativeClassPtr, nameof (StopPatrol));
      MiscAiGameplayData.NativeFieldInfoPtr_IsFleeing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscAiGameplayData>.NativeClassPtr, nameof (IsFleeing));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MiscAiGameplayData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
