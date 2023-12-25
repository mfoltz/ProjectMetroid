// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.EtherialState_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct EtherialState_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EtherealBuffEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_VulnerableBuffEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageReductionFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_VulnerabilityTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Vulnerable;
    private static readonly System.IntPtr NativeFieldInfoPtr_WasCasting;
    [FieldOffset(0)]
    public PrefabGUID EtherealBuffEntity;
    [FieldOffset(4)]
    public PrefabGUID VulnerableBuffEntity;
    [FieldOffset(8)]
    public float DamageReductionFactor;
    [FieldOffset(12)]
    public float VulnerabilityTime;
    [FieldOffset(16)]
    public Entity BuffEntity;
    [FieldOffset(24)]
    public bool Vulnerable;
    [FieldOffset(25)]
    public bool WasCasting;

    static EtherialState_DataShared()
    {
      Il2CppClassPointerStore<EtherialState_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (EtherialState_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EtherialState_DataShared>.NativeClassPtr);
      EtherialState_DataShared.NativeFieldInfoPtr_EtherealBuffEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EtherialState_DataShared>.NativeClassPtr, nameof (EtherealBuffEntity));
      EtherialState_DataShared.NativeFieldInfoPtr_VulnerableBuffEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EtherialState_DataShared>.NativeClassPtr, nameof (VulnerableBuffEntity));
      EtherialState_DataShared.NativeFieldInfoPtr_DamageReductionFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EtherialState_DataShared>.NativeClassPtr, nameof (DamageReductionFactor));
      EtherialState_DataShared.NativeFieldInfoPtr_VulnerabilityTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EtherialState_DataShared>.NativeClassPtr, nameof (VulnerabilityTime));
      EtherialState_DataShared.NativeFieldInfoPtr_BuffEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EtherialState_DataShared>.NativeClassPtr, nameof (BuffEntity));
      EtherialState_DataShared.NativeFieldInfoPtr_Vulnerable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EtherialState_DataShared>.NativeClassPtr, nameof (Vulnerable));
      EtherialState_DataShared.NativeFieldInfoPtr_WasCasting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EtherialState_DataShared>.NativeClassPtr, nameof (WasCasting));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EtherialState_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
